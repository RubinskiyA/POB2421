namespace Lesson25_2
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
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Small", 22F);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(141, 218);
            label1.Name = "label1";
            label1.Size = new Size(274, 145);
            label1.TabIndex = 0;
            label1.Text = "Добро пожаловать!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 11F);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(109, 320);
            label2.Name = "label2";
            label2.Size = new Size(288, 25);
            label2.TabIndex = 1;
            label2.Text = "Сайт ультрамодного барбершопа";
            // 
            // button1
            // 
            button1.BackColor = Color.Orchid;
            button1.Location = new Point(76, 501);
            button1.Name = "button1";
            button1.Size = new Size(268, 69);
            button1.TabIndex = 2;
            button1.Text = "        Login                      ->";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(128, 573);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 3;
            label3.Text = "У вас нет аккаунта?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.ButtonFace;
            linkLabel1.Location = new Point(268, 573);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(68, 20);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Создать!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Снимок_экрана_2024_07_13_144229;
            ClientSize = new Size(427, 636);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}
