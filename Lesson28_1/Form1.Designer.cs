namespace Lesson28_1
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
            labelRandomText = new Label();
            SuspendLayout();
            // 
            // labelRandomText
            // 
            labelRandomText.AutoSize = true;
            labelRandomText.Font = new Font("Segoe UI", 12F);
            labelRandomText.Location = new Point(21, 58);
            labelRandomText.Name = "labelRandomText";
            labelRandomText.Size = new Size(0, 21);
            labelRandomText.TabIndex = 0;
            labelRandomText.Click += labelRandomText_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 143);
            Controls.Add(labelRandomText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRandomText;
    }
}
