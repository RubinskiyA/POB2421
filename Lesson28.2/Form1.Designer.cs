﻿namespace Lesson28._2
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            buttonLogIn = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 57);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(25, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 39);
            textBox1.TabIndex = 1;
            textBox1.Text = "Enter username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 140);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 18F);
            textBox2.ForeColor = SystemColors.ScrollBar;
            textBox2.Location = new Point(25, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 39);
            textBox2.TabIndex = 3;
            textBox2.Text = "Enter password";
            // 
            // buttonLogIn
            // 
            buttonLogIn.Font = new Font("Segoe UI", 15F);
            buttonLogIn.Location = new Point(151, 248);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(75, 37);
            buttonLogIn.TabIndex = 4;
            buttonLogIn.Text = "Log in";
            buttonLogIn.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(179, 288);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(47, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sing up";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(249, 325);
            Controls.Add(linkLabel1);
            Controls.Add(buttonLogIn);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Authorisation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button buttonLogIn;
        private LinkLabel linkLabel1;
    }
}
