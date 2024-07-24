namespace Lesson35_3_Biblio_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listBoxTitle = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            listBoxAuthor = new ListBox();
            label3 = new Label();
            listBoxYear = new ListBox();
            label4 = new Label();
            textBoxTitle = new TextBox();
            textBoxAuthor = new TextBox();
            label5 = new Label();
            textBoxYear = new TextBox();
            label6 = new Label();
            buttonAdd = new Button();
            buttonExport = new Button();
            label7 = new Label();
            textBoxSearch = new TextBox();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxTitle
            // 
            listBoxTitle.ContextMenuStrip = contextMenuStrip1;
            listBoxTitle.FormattingEnabled = true;
            listBoxTitle.ItemHeight = 15;
            listBoxTitle.Location = new Point(49, 75);
            listBoxTitle.Name = "listBoxTitle";
            listBoxTitle.Size = new Size(167, 364);
            listBoxTitle.TabIndex = 0;
            listBoxTitle.SelectedIndexChanged += listBoxTitle_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { удалитьToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(119, 26);
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(118, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 51);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 3;
            label1.Text = "Название книги:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 51);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "Автор:";
            // 
            // listBoxAuthor
            // 
            listBoxAuthor.FormattingEnabled = true;
            listBoxAuthor.ItemHeight = 15;
            listBoxAuthor.Location = new Point(222, 75);
            listBoxAuthor.Name = "listBoxAuthor";
            listBoxAuthor.Size = new Size(167, 364);
            listBoxAuthor.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(395, 51);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 7;
            label3.Text = "Год написания:";
            // 
            // listBoxYear
            // 
            listBoxYear.FormattingEnabled = true;
            listBoxYear.ItemHeight = 15;
            listBoxYear.Location = new Point(395, 75);
            listBoxYear.Name = "listBoxYear";
            listBoxYear.Size = new Size(167, 364);
            listBoxYear.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(589, 51);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 8;
            label4.Text = "Название:";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(589, 75);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(128, 23);
            textBoxTitle.TabIndex = 9;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(589, 138);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(128, 23);
            textBoxAuthor.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(589, 114);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 10;
            label5.Text = "Автор:";
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(589, 206);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(128, 23);
            textBoxYear.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(589, 182);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 12;
            label6.Text = "Год:";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(589, 261);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(144, 36);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "Добавить книгу";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonExport
            // 
            buttonExport.Location = new Point(589, 312);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(144, 38);
            buttonExport.TabIndex = 15;
            buttonExport.Text = "Выгрузить список";
            buttonExport.UseVisualStyleBackColor = true;
            buttonExport.Click += buttonExport_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 457);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 16;
            label7.Text = "Поиск";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(86, 455);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(476, 23);
            textBoxSearch.TabIndex = 17;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 490);
            Controls.Add(textBoxSearch);
            Controls.Add(label7);
            Controls.Add(buttonExport);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxYear);
            Controls.Add(label6);
            Controls.Add(textBoxAuthor);
            Controls.Add(label5);
            Controls.Add(textBoxTitle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBoxYear);
            Controls.Add(label2);
            Controls.Add(listBoxAuthor);
            Controls.Add(label1);
            Controls.Add(listBoxTitle);
            Name = "Form1";
            Text = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxTitle;
        private Label label1;
        private Label label2;
        private ListBox listBoxAuthor;
        private Label label3;
        private ListBox listBoxYear;
        private Label label4;
        private TextBox textBoxTitle;
        private TextBox textBoxAuthor;
        private Label label5;
        private TextBox textBoxYear;
        private Label label6;
        private Button buttonAdd;
        private Button buttonExport;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private Label label7;
        private TextBox textBoxSearch;
    }
}
