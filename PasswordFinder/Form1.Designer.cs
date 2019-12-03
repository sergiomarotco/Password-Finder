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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // richTextBox2
            // 
            resources.ApplyResources(this.richTextBox2, "richTextBox2");
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.TextChanged += new System.EventHandler(this.RichTextBox2_TextChanged);
            // 
            // richTextBox3
            // 
            resources.ApplyResources(this.richTextBox3, "richTextBox3");
            this.richTextBox3.Name = "richTextBox3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            // 
            // listView1
            // 
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // docBox
            // 
            resources.ApplyResources(this.docBox, "docBox");
            this.docBox.Checked = true;
            this.docBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.docBox.Name = "docBox";
            this.docBox.UseVisualStyleBackColor = true;
            // 
            // xlsBox
            // 
            resources.ApplyResources(this.xlsBox, "xlsBox");
            this.xlsBox.Name = "xlsBox";
            this.xlsBox.UseVisualStyleBackColor = true;
            // 
            // txtBox
            // 
            resources.ApplyResources(this.txtBox, "txtBox");
            this.txtBox.Name = "txtBox";
            this.txtBox.UseVisualStyleBackColor = true;
            // 
            // rtfBox
            // 
            resources.ApplyResources(this.rtfBox, "rtfBox");
            this.rtfBox.Name = "rtfBox";
            this.rtfBox.UseVisualStyleBackColor = true;
            // 
            // xmlBox
            // 
            resources.ApplyResources(this.xmlBox, "xmlBox");
            this.xmlBox.Name = "xmlBox";
            this.xmlBox.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // preferencesToolStripMenuItem
            // 
            resources.ApplyResources(this.preferencesToolStripMenuItem, "preferencesToolStripMenuItem");
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.langToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            // 
            // langToolStripMenuItem
            // 
            resources.ApplyResources(this.langToolStripMenuItem, "langToolStripMenuItem");
            this.langToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.engToolStripMenuItem,
            this.rusToolStripMenuItem});
            this.langToolStripMenuItem.Name = "langToolStripMenuItem";
            // 
            // engToolStripMenuItem
            // 
            resources.ApplyResources(this.engToolStripMenuItem, "engToolStripMenuItem");
            this.engToolStripMenuItem.Name = "engToolStripMenuItem";
            this.engToolStripMenuItem.Click += new System.EventHandler(this.EngToolStripMenuItem_Click);
            // 
            // rusToolStripMenuItem
            // 
            resources.ApplyResources(this.rusToolStripMenuItem, "rusToolStripMenuItem");
            this.rusToolStripMenuItem.Name = "rusToolStripMenuItem";
            this.rusToolStripMenuItem.Click += new System.EventHandler(this.RusToolStripMenuItem_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Load += new System.EventHandler(this.Form1_Load);
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

