using System;
using ExcelDataReader;
using System.IO;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Word = Microsoft.Office.Interop.Word;
using System.Xml;

namespace PasswordFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<string> RemoveDuplicate(List<string> sourceList)
        {
            sourceList.Sort();
            for (int i = sourceList.Count - 1; i >= 0; i--)
                for (int j = sourceList.Count - 1; j >= 0; j--)
                    if (i != j)
                        if (sourceList[i].Equals(sourceList[j]))
                        {
                            sourceList.RemoveAt(i);
                            break;
                        }
                        else
                        {
                            if (sourceList[i].Contains("~$"))
                            {
                                sourceList.RemoveAt(i);
                                break;
                            }
                        }
            return sourceList;
        }

        /// <summary>
        /// Дополняет базовую строку выделенными галками
        /// </summary>
        /// <param name="base_Text"></param>
        /// <returns></returns>
        private string Prepare_File_patterns(string base_Text)
        {
            string pat = base_Text;
            if (docBox.Checked)
                pat += ",*.doc,*.docx";
            if (xlsBox.Checked)
                pat += ",*.xls,*.xlsx";
            if (txtBox.Checked)
                pat += ",*.txt";
            if (rtfBox.Checked)
                pat += ",*.rtf";
            if (xmlBox.Checked)
                pat += ",*.xml";
            return pat;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string[] Directories = richTextBox1.Lines;
            List<string> Files = new List<string>();
            List<string> Files_with_password = new List<string>();
            
            string[] File_patterns = Prepare_File_patterns(richTextBox2.Text).Split(',');
            string[] PWD_patterns = richTextBox3.Text.Split(',');
            for (int i = 0; i < Directories.Length; i++)
                for (int j = 0; j < File_patterns.Length; j++)
                    Files.AddRange(Directory.GetFiles(Directories[i], File_patterns[j], SearchOption.AllDirectories));

            RemoveDuplicate(Files);//удалить дубликаты найденные по разным правилам
            for (int f = 0; f < Files.Count; f++)
            {
                string ext = Path.GetExtension(Files[f]).ToLower();
                toolStripStatusLabel1.Text = f + 1 + " / " + Files.Count;
                bool isexit = false;
                if (Files[f].Contains(".xls", StringComparison.OrdinalIgnoreCase))
                {
                    //--------------------------------------------Sergiomarotco Slow way
                    /*Excel.Worksheet Sheet = new Excel.Worksheet(); //какой-то рабочий лист Excel
                    Excel.Application Excel_App = new Excel.Application(); //создаём приложение Excel
                    Excel.Workbook Book = Excel_App.Workbooks.Open(Files[f]); //открываем наш файл (Рабочую книгу Excel) //xlApp.Visible = true; //сделать Excel видимым, но это не обязательно
                    foreach (Excel.Worksheet worksheet in Book.Worksheets)
                    {
                        Sheet = Book.Worksheets[worksheet.Name]; //присваиваем переменной iSht Лист1 или так xlSht = xlWB.ActiveSheet //активный лист
                        for (int p = 0; p < PWD_patterns.Length; p++)
                        {
                            Excel.Range range = Sheet.get_Range("A1", "J100").Find(PWD_patterns[p]);
                            if (range != null)
                            {
                                string findedpwd = string.Empty;
                                try
                                {
                                    if ((range.Column - 2) >= 0)
                                        findedpwd += Sheet.get_Range(GetLetterByNum(range.Column - 2) + range.Row.ToString()).Text + " ";
                                }
                                catch (Exception ee) { MessageBox.Show(ee.ToString()); }
                                try
                                {
                                    if ((range.Column - 1) >= 0)
                                        findedpwd += Sheet.get_Range(GetLetterByNum(range.Column - 1) + range.Row.ToString()).Text + " ";
                                }
                                catch (Exception ee) { MessageBox.Show(ee.ToString()); }
                                try
                                {
                                    if ((range.Column) >= 0)
                                        findedpwd += Sheet.get_Range(GetLetterByNum(range.Column) + range.Row.ToString()).Text + " ";
                                }
                                catch (Exception ee) { MessageBox.Show(ee.ToString()); }
                                findedpwd += Sheet.get_Range(GetLetterByNum(range.Column + 1) + range.Row.ToString()).Text + " ";
                                findedpwd += Sheet.get_Range(GetLetterByNum(range.Column + 2) + range.Row.ToString()).Text + " ";
                                listView1.Items.Add(new ListViewItem(new string[] { Files[f], findedpwd.TrimEnd(' ').TrimStart(' '), ext }));
                            }
                        }
                    }
                    Book.Close(false); //сохраняем и закрываем файл, если false - то закрыть и не сохранить изменения
                    Excel_App.Quit();
                    */
                    try
                    {
                        //--------------------------------------------https://github.com/ExcelDataReader Faster way
                        using (FileStream stream = File.Open(Files[f], FileMode.Open, FileAccess.Read))
                        {
                            // Auto-detect format, supports:
                            //  - Binary Excel files (2.0-2003 format; *.xls)
                            //  - OpenXml Excel files (2007 format; *.xlsx)
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                do
                                {
                                    while (reader.Read())
                                    {
                                        // reader.GetDouble(0);
                                    }
                                } while (reader.NextResult());
                                DataSet result = reader.AsDataSet();// The result of each spreadsheet is in result.Tables
                                for (int t = 0; t < result.Tables.Count; t++)
                                {
                                    for (int p = 0; p < PWD_patterns.Length; p++)
                                    {
                                        int columns_c = result.Tables[t].Columns.Count;
                                        //if (columns_c > 3) columns_c = 3;
                                        for (int c = 0; c < columns_c; c++)
                                        {
                                            DataRow[] range = result.Tables[t].Select(result.Tables[t].Columns[c].ColumnName + " like '%" + PWD_patterns[p] + "%'");
                                            if (range != null)
                                            {
                                                if (range.Length != 0)
                                                {
                                                    for (int j = 0; j < range.Length; j++)
                                                    {
                                                        listView1.Items.Add(new ListViewItem(new string[] { Files[f], String.Join(" ", range[j].ItemArray), ext }));
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch { }
                    isexit = true;
                }
                if (Files[f].Contains(".docx", StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        Word.Application app = new Word.Application();
                        var doc = app.Documents.Open(Files[f]);
                        for (int p = 0; p < PWD_patterns.Length; p++)
                        {
                            //FindReplace(documentLocation, findText, replaceText);
                            var range = doc.Range();
                            //Word.Application.Selection.Find.ClearFormatting();
                            if (range.Find.Execute(PWD_patterns[p]))
                            {
                                Word.Range wordRange;// диапазон документа Word
                                try
                                {
                                    for (int i = 1; i <= doc.Sections.Count; i++)// обходим все разделы документа
                                    {
                                        wordRange = doc.Sections[i].Range;// берем всю секцию диапазоном                                   
                                        wordRange.Find.Execute(PWD_patterns[p]);// выполняем метод поискаи замены обьекта диапазона ворд
                                    }
                                }
                                catch { }
                                // завершение функции поиска и замены SearchAndReplace
                            }
                        }
                        doc.Close();
                        app.Quit();
                        Marshal.ReleaseComObject(app);
                    }
                    catch { }                 
                    isexit = true;
                }
                if (Files[f].Contains(".xml", StringComparison.OrdinalIgnoreCase))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(Files[f]);

                    for (int p = 0; p < PWD_patterns.Length; p++)
                    {//Display all the book titles.
                        XmlNodeList elemList = doc.GetElementsByTagName(PWD_patterns[p]);
                        for (int i = 0; i < elemList.Count; i++)
                        {
                            listView1.Items.Add(new ListViewItem(new string[] { Files[f], elemList[i].OuterXml, ext }));
                        }
                    }
                    isexit = true;
                }
                if (!isexit)//если это не word и не excel то втупую поиск по файлу
                {
                    string findedpwd = string.Empty;
                    string[] Lines = File.ReadAllLines(Files[f], Encoding.Default);
                    for (int l = 0; l < Lines.Length; l++)
                    {
                        for (int p = 0; p < PWD_patterns.Length; p++)
                        {
                            if (Lines[l].Contains(PWD_patterns[p], StringComparison.OrdinalIgnoreCase))
                            {
                                Files_with_password.Add(Files[f]);
                                string[] Words = Lines[l].Split(' ');
                                for (int w = 0; w < Words.Length; w++)
                                {
                                    if (Words[w].Contains(PWD_patterns[p]))
                                    {
                                        int w2 = w;
                                        if ((w2 - 2) >= 0) findedpwd += Words[w2 - 2] + " ";
                                        if ((w2 - 1) >= 0) findedpwd += Words[w2 - 1] + " ";
                                        if ((w2) >= 0) findedpwd += Words[w2] + " ";
                                        if ((w2 + 1) < Words.Length) findedpwd += Words[w2 + 1] + " ";
                                        if ((w2 + 2) < Words.Length) findedpwd += Words[w2 + 2] + " ";
                                        listView1.Items.Add(new ListViewItem(new string[] { Files[f], findedpwd.TrimEnd(' ').TrimStart(' '), ext }));
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            toolStripStatusLabel1.Text = "Выполнено";
        }

        private static IList<string> GetTablenames(DataTableCollection tables)
        {
            var tableList = new List<string>();
            foreach (var table in tables)
            {
                tableList.Add(table.ToString());
            }

            return tableList;
        }
        /// <summary>
        /// перевод порядкового номера столбца в его буквенный эквивалент.
        /// </summary>
        /// <param name="colNum"></param>
        /// <returns></returns>
        public static string ParseColNum(int colNum)
        {
            // тут конечно каждый сам по своему может контролировать (так как для офиса 2007 это не актуально)
            if (colNum > 256)
            {
                //MessageBox.Show(@"Кол-во колонок не должно быть более 256!");
                return "error";
            }

            char res = 'A';

            if (colNum < 27) return GetLetterByNum(colNum);

            while (colNum > 52)
            {
                colNum -= 26;
                res += (char)(res + 1);
            }

            colNum -= 26;
            return (res) + GetLetterByNum(colNum);
        }

        /// <summary>
        /// ф. получения буквы по номеру столбца (для Excel)
        /// </summary>
        /// <param name="colNum">номер столбца</param>
        /// <returns></returns>
        private static string GetLetterByNum(int colNum)
        {
            if (colNum <= 0) return "A";
            var book = new string[26];

            for (int i = 0; i < 26; i++)
            {
                book[i] = (((char)('A' + i)).ToString());
            }

            return book[colNum - 1];
        }

        private void RichTextBox2_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.Text=richTextBox2.Text.Replace("*.doc", "");
            richTextBox2.Text = richTextBox2.Text.Replace("*.xls", "");
            richTextBox2.Text = richTextBox2.Text.Replace("*.txt", "");
            richTextBox2.Text = richTextBox2.Text.Replace("*.rtf", "");
            richTextBox2.Text = richTextBox2.Text.Replace("*.xml", "");
            richTextBox2.Text = richTextBox2.Text.Replace(",,", "");

        }

        private void RusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "Список слов для поиска файлов (* - поиск по всем файлам):";
            label5.Text = "Список слов для поиска паролей:";
            button1.Text = "Найти пароли";
            label3.Text = "Папки где искать файлы:";
        }

        private void EngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "Text to find files (* - analyze all files):";
            label5.Text = "Word for find passwords:";
            button1.Text = "Find passwords";
            label3.Text = "Folders where find files:";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.ico;
        }
    }
    public static class StringExtensions
    {
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source.IndexOf(toCheck, comp) >= 0;
        }
    }
}
