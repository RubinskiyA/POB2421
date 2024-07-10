namespace Lesson33_1
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
            textBoxDist = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            labelDistance = new Label();
            comboBoxDist = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            label3 = new Label();
            labelPresure = new Label();
            comboBoxPres = new ComboBox();
            textBoxPres = new TextBox();
            panel3 = new Panel();
            groupBox3 = new GroupBox();
            label2 = new Label();
            labelTemper = new Label();
            comboBoxTemp = new ComboBox();
            textBoxTemp = new TextBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxDist
            // 
            textBoxDist.Location = new Point(24, 41);
            textBoxDist.Name = "textBoxDist";
            textBoxDist.Size = new Size(82, 23);
            textBoxDist.TabIndex = 0;
            textBoxDist.TextChanged += textBoxDist_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(labelDistance);
            groupBox1.Controls.Add(comboBoxDist);
            groupBox1.Controls.Add(textBoxDist);
            groupBox1.Location = new Point(44, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(446, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Расстояние";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 44);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 3;
            label1.Text = "мм.";
            // 
            // labelDistance
            // 
            labelDistance.Location = new Point(255, 41);
            labelDistance.Name = "labelDistance";
            labelDistance.Size = new Size(173, 20);
            labelDistance.TabIndex = 2;
            // 
            // comboBoxDist
            // 
            comboBoxDist.FormattingEnabled = true;
            comboBoxDist.Items.AddRange(new object[] { "Дециметры", "Километры", "Метры", "Сантиметры" });
            comboBoxDist.Location = new Point(154, 44);
            comboBoxDist.Name = "comboBoxDist";
            comboBoxDist.Size = new Size(89, 23);
            comboBoxDist.Sorted = true;
            comboBoxDist.TabIndex = 1;
            comboBoxDist.SelectedIndexChanged += comboBoxDist_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 152);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 299);
            panel2.Name = "panel2";
            panel2.Size = new Size(541, 151);
            panel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(labelPresure);
            groupBox2.Controls.Add(comboBoxPres);
            groupBox2.Controls.Add(textBoxPres);
            groupBox2.Location = new Point(44, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(446, 100);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Давление";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 44);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 5;
            label3.Text = "Па";
            // 
            // labelPresure
            // 
            labelPresure.Location = new Point(272, 44);
            labelPresure.Name = "labelPresure";
            labelPresure.Size = new Size(156, 20);
            labelPresure.TabIndex = 2;
            // 
            // comboBoxPres
            // 
            comboBoxPres.FormattingEnabled = true;
            comboBoxPres.Items.AddRange(new object[] { "Мм.рт.ст", "Бары", "Атмосферы", "Килограмм-силы" });
            comboBoxPres.Location = new Point(154, 41);
            comboBoxPres.Name = "comboBoxPres";
            comboBoxPres.Size = new Size(89, 23);
            comboBoxPres.TabIndex = 1;
            // 
            // textBoxPres
            // 
            textBoxPres.Location = new Point(24, 41);
            textBoxPres.Name = "textBoxPres";
            textBoxPres.Size = new Size(82, 23);
            textBoxPres.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 152);
            panel3.Name = "panel3";
            panel3.Size = new Size(541, 147);
            panel3.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(labelTemper);
            groupBox3.Controls.Add(comboBoxTemp);
            groupBox3.Controls.Add(textBoxTemp);
            groupBox3.Location = new Point(44, 21);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(446, 100);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Температура";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 44);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 4;
            label2.Text = "Гр.Ц";
            // 
            // labelTemper
            // 
            labelTemper.Location = new Point(272, 44);
            labelTemper.Name = "labelTemper";
            labelTemper.Size = new Size(156, 20);
            labelTemper.TabIndex = 2;
            // 
            // comboBoxTemp
            // 
            comboBoxTemp.FormattingEnabled = true;
            comboBoxTemp.Items.AddRange(new object[] { "Кельвины", "Фаренгейты" });
            comboBoxTemp.Location = new Point(154, 41);
            comboBoxTemp.Name = "comboBoxTemp";
            comboBoxTemp.Size = new Size(89, 23);
            comboBoxTemp.TabIndex = 1;
            comboBoxTemp.SelectedIndexChanged += comboBoxTemp_SelectedIndexChanged_1;
            // 
            // textBoxTemp
            // 
            textBoxTemp.Location = new Point(24, 41);
            textBoxTemp.Name = "textBoxTemp";
            textBoxTemp.Size = new Size(82, 23);
            textBoxTemp.TabIndex = 0;
            textBoxTemp.TextChanged += textBoxTemp_TextChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxDist;
        private GroupBox groupBox1;
        private Label labelDistance;
        private ComboBox comboBoxDist;
        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox2;
        private Label labelPresure;
        private ComboBox comboBoxPres;
        private TextBox textBoxPres;
        private Panel panel3;
        private GroupBox groupBox3;
        private Label labelTemper;
        private ComboBox comboBoxTemp;
        private TextBox textBoxTemp;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}
