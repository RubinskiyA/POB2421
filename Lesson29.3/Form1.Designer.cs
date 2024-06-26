namespace Lesson29._3
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
            folderBrowserDialog1 = new FolderBrowserDialog();
            listBoxPictures = new ListBox();
            buttonOpen = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxPictures
            // 
            listBoxPictures.Font = new Font("Calibri", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            listBoxPictures.FormattingEnabled = true;
            listBoxPictures.ItemHeight = 15;
            listBoxPictures.Location = new Point(27, 22);
            listBoxPictures.Name = "listBoxPictures";
            listBoxPictures.Size = new Size(296, 289);
            listBoxPictures.TabIndex = 0;
            listBoxPictures.SelectedIndexChanged += listBoxPictures_SelectedIndexChanged;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(27, 330);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(296, 39);
            buttonOpen.TabIndex = 1;
            buttonOpen.Text = "Загрузить";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(375, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(392, 347);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 387);
            Controls.Add(pictureBox1);
            Controls.Add(buttonOpen);
            Controls.Add(listBoxPictures);
            Name = "Form1";
            Text = "Просмотр фотографий";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private ListBox listBoxPictures;
        private Button buttonOpen;
        private PictureBox pictureBox1;
    }
}
