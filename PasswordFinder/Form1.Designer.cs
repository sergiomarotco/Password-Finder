namespace PasswordFinder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.docBox = new System.Windows.Forms.CheckBox();
            this.xlsBox = new System.Windows.Forms.CheckBox();
            this.txtBox = new System.Windows.Forms.CheckBox();
            this.rtfBox = new System.Windows.Forms.CheckBox();
            this.xmlBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.langToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(731, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Find passwords";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(731, 157);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "C:\\Users\\Sergiomarotco\\Documents\\Visual Studio 2017\\Projects\\PasswordFinder\\Passw" +
    "ordFinder\\тест";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список папок для поиска паролей:";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(817, 51);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(406, 129);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "*парол*,*pass*,*pwd*,*логин*,*login*";
            this.richTextBox2.TextChanged += new System.EventHandler(this.RichTextBox2_TextChanged);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(749, 211);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(474, 49);
            this.richTextBox3.TabIndex = 4;
            this.richTextBox3.Text = "pwd,pass,парол,пасс,парл,password,пароль\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(746, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Text to find files (* - analyze all files):";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 703);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1235, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 266);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1235, 437);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Файл";
            this.columnHeader1.Width = 800;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Пароль";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Тип";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(746, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Word for find passwords:";
            // 
            // docBox
            // 
            this.docBox.AutoSize = true;
            this.docBox.Checked = true;
            this.docBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.docBox.Location = new System.Drawing.Point(749, 51);
            this.docBox.Name = "docBox";
            this.docBox.Size = new System.Drawing.Size(62, 21);
            this.docBox.TabIndex = 14;
            this.docBox.Text = "*.doc";
            this.docBox.UseVisualStyleBackColor = true;
            // 
            // xlsBox
            // 
            this.xlsBox.AutoSize = true;
            this.xlsBox.Location = new System.Drawing.Point(749, 78);
            this.xlsBox.Name = "xlsBox";
            this.xlsBox.Size = new System.Drawing.Size(55, 21);
            this.xlsBox.TabIndex = 14;
            this.xlsBox.Text = "*.xls";
            this.xlsBox.UseVisualStyleBackColor = true;
            // 
            // txtBox
            // 
            this.txtBox.AutoSize = true;
            this.txtBox.Location = new System.Drawing.Point(749, 105);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(53, 21);
            this.txtBox.TabIndex = 14;
            this.txtBox.Text = "*.txt";
            this.txtBox.UseVisualStyleBackColor = true;
            // 
            // rtfBox
            // 
            this.rtfBox.AutoSize = true;
            this.rtfBox.Location = new System.Drawing.Point(749, 132);
            this.rtfBox.Name = "rtfBox";
            this.rtfBox.Size = new System.Drawing.Size(52, 21);
            this.rtfBox.TabIndex = 14;
            this.rtfBox.Text = "*.rtf";
            this.rtfBox.UseVisualStyleBackColor = true;
            // 
            // xmlBox
            // 
            this.xmlBox.AutoSize = true;
            this.xmlBox.Location = new System.Drawing.Point(749, 159);
            this.xmlBox.Name = "xmlBox";
            this.xmlBox.Size = new System.Drawing.Size(59, 21);
            this.xmlBox.TabIndex = 14;
            this.xmlBox.Text = "*.xml";
            this.xmlBox.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1235, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.langToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // langToolStripMenuItem
            // 
            this.langToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.engToolStripMenuItem,
            this.rusToolStripMenuItem});
            this.langToolStripMenuItem.Name = "langToolStripMenuItem";
            this.langToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.langToolStripMenuItem.Text = "Lang";
            // 
            // engToolStripMenuItem
            // 
            this.engToolStripMenuItem.Name = "engToolStripMenuItem";
            this.engToolStripMenuItem.Size = new System.Drawing.Size(109, 26);
            this.engToolStripMenuItem.Text = "Eng";
            this.engToolStripMenuItem.Click += new System.EventHandler(this.EngToolStripMenuItem_Click);
            // 
            // rusToolStripMenuItem
            // 
            this.rusToolStripMenuItem.Name = "rusToolStripMenuItem";
            this.rusToolStripMenuItem.Size = new System.Drawing.Size(109, 26);
            this.rusToolStripMenuItem.Text = "Rus";
            this.rusToolStripMenuItem.Click += new System.EventHandler(this.RusToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Folders where find files:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 725);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xmlBox);
            this.Controls.Add(this.rtfBox);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.xlsBox);
            this.Controls.Add(this.docBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поисковик паролей";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox docBox;
        private System.Windows.Forms.CheckBox xlsBox;
        private System.Windows.Forms.CheckBox txtBox;
        private System.Windows.Forms.CheckBox rtfBox;
        private System.Windows.Forms.CheckBox xmlBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem langToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem engToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rusToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}

