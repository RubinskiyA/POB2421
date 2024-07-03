namespace Lesson31._2
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
            listBoxFiles = new ListBox();
            textBoxText = new TextBox();
            buttonDel = new Button();
            buttonSave = new Button();
            label1 = new Label();
            label2 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // listBoxFiles
            // 
            listBoxFiles.FormattingEnabled = true;
            listBoxFiles.ItemHeight = 15;
            listBoxFiles.Location = new Point(31, 38);
            listBoxFiles.Name = "listBoxFiles";
            listBoxFiles.Size = new Size(169, 319);
            listBoxFiles.TabIndex = 0;
            listBoxFiles.SelectedIndexChanged += listBoxFiles_SelectedIndexChanged_1;
            // 
            // textBoxText
            // 
            textBoxText.Location = new Point(241, 38);
            textBoxText.Multiline = true;
            textBoxText.Name = "textBoxText";
            textBoxText.Size = new Size(208, 319);
            textBoxText.TabIndex = 1;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(71, 379);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(76, 23);
            buttonDel.TabIndex = 3;
            buttonDel.Text = "DeleteFile";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click_1;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(256, 379);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(175, 23);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 20);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 5;
            label1.Text = "Выберите файл";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 20);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 6;
            label2.Text = "Содержимое файла";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 422);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Controls.Add(buttonDel);
            Controls.Add(textBoxText);
            Controls.Add(listBoxFiles);
            Name = "Form1";
            Text = "Файловый менеджер";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxFiles;
        private TextBox textBoxText;
        private Button buttonDel;
        private Button buttonSave;
        private Label label1;
        private Label label2;
        private FolderBrowserDialog folderBrowserDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
