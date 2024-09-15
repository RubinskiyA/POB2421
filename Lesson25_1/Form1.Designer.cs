namespace Lesson25_1
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
            label3 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            label5 = new Label();
            listBox5 = new ListBox();
            listBox6 = new ListBox();
            label6 = new Label();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label8 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 32);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Задача";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 32);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 1;
            label2.Text = "Время выполнения";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(501, 32);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Статус";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(333, 32);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 3;
            label4.Text = "Исполнитель";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 59);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 319);
            listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(166, 59);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 319);
            listBox2.TabIndex = 5;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(317, 59);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(120, 319);
            listBox3.TabIndex = 6;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(465, 59);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(120, 319);
            listBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(644, 59);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 9;
            label5.Text = "Выберите статус";
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 15;
            listBox5.Items.AddRange(new object[] { "Выполнено", "Заморожено", "В работе" });
            listBox5.Location = new Point(644, 77);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(120, 49);
            listBox5.TabIndex = 10;
            // 
            // listBox6
            // 
            listBox6.FormattingEnabled = true;
            listBox6.ItemHeight = 15;
            listBox6.Items.AddRange(new object[] { "Иванов", "Петров", "Федоров" });
            listBox6.Location = new Point(644, 159);
            listBox6.Name = "listBox6";
            listBox6.Size = new Size(120, 49);
            listBox6.TabIndex = 12;
            listBox6.SelectedIndexChanged += listBox6_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(644, 141);
            label6.Name = "label6";
            label6.Size = new Size(136, 15);
            label6.TabIndex = 11;
            label6.Text = "Выберите исполнителя";
            label6.Click += this.label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(646, 232);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 13;
            label7.Text = "Укажите дату";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(629, 250);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(642, 292);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 15;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(642, 321);
            button2.Name = "button2";
            button2.Size = new Size(122, 23);
            button2.TabIndex = 16;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(642, 355);
            button3.Name = "button3";
            button3.Size = new Size(122, 23);
            button3.TabIndex = 17;
            button3.Text = "Перезаписать";
            button3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(37, 402);
            label8.Name = "label8";
            label8.Size = new Size(124, 15);
            label8.TabIndex = 18;
            label8.Text = "Укажите текст задачи";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 420);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(514, 23);
            textBox1.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 452);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(listBox6);
            Controls.Add(label6);
            Controls.Add(listBox5);
            Controls.Add(label5);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label3);
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
        private Label label3;
        private Label label4;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private Label label5;
        private ListBox listBox5;
        private ListBox listBox6;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label8;
        private TextBox textBox1;
    }
}
