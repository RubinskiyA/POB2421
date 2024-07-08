namespace Lesson32_4
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
            this.buttonForColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonForColor
            // 
            this.buttonForColor.Location = new System.Drawing.Point(44, 44);
            this.buttonForColor.Name = "buttonForColor";
            this.buttonForColor.Size = new System.Drawing.Size(170, 154);
            this.buttonForColor.TabIndex = 0;
            this.buttonForColor.Text = "Нажми меня!";
            this.buttonForColor.UseVisualStyleBackColor = true;
            this.buttonForColor.Click += new System.EventHandler(this.buttonForColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 259);
            this.Controls.Add(this.buttonForColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonForColor;
    }
}