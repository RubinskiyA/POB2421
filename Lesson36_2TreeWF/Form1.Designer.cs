namespace Lesson36_2TreeWF
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
            treeViewList = new TreeView();
            buttonTree = new Button();
            labelPath = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            checkBoxFiles = new CheckBox();
            labelFileInfo = new Label();
            SuspendLayout();
            // 
            // treeViewList
            // 
            treeViewList.Location = new Point(12, 23);
            treeViewList.Name = "treeViewList";
            treeViewList.Size = new Size(359, 411);
            treeViewList.TabIndex = 0;
            treeViewList.MouseClick += treeViewList_MouseClick;
            // 
            // buttonTree
            // 
            buttonTree.Location = new Point(21, 469);
            buttonTree.Name = "buttonTree";
            buttonTree.Size = new Size(137, 34);
            buttonTree.TabIndex = 1;
            buttonTree.Text = "Выбрать папку";
            buttonTree.UseVisualStyleBackColor = true;
            buttonTree.Click += buttonTree_Click;
            // 
            // labelPath
            // 
            labelPath.AutoSize = true;
            labelPath.Location = new Point(174, 479);
            labelPath.Name = "labelPath";
            labelPath.Size = new Size(0, 15);
            labelPath.TabIndex = 2;
            // 
            // checkBoxFiles
            // 
            checkBoxFiles.AutoSize = true;
            checkBoxFiles.Location = new Point(21, 444);
            checkBoxFiles.Name = "checkBoxFiles";
            checkBoxFiles.Size = new Size(132, 19);
            checkBoxFiles.TabIndex = 3;
            checkBoxFiles.Text = "Показывать файлы";
            checkBoxFiles.UseVisualStyleBackColor = true;
            checkBoxFiles.CheckedChanged += checkBoxFiles_CheckedChanged;
            // 
            // labelFileInfo
            // 
            labelFileInfo.Location = new Point(395, 27);
            labelFileInfo.Name = "labelFileInfo";
            labelFileInfo.Size = new Size(134, 407);
            labelFileInfo.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 538);
            Controls.Add(labelFileInfo);
            Controls.Add(checkBoxFiles);
            Controls.Add(labelPath);
            Controls.Add(buttonTree);
            Controls.Add(treeViewList);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeViewList;
        private Button buttonTree;
        private Label labelPath;
        private FolderBrowserDialog folderBrowserDialog1;
        private CheckBox checkBoxFiles;
        private Label labelFileInfo;
    }
}
