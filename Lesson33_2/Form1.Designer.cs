namespace Lesson33_2
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
            listBoxTask = new ListBox();
            label1 = new Label();
            label2 = new Label();
            textBoxTextTask = new TextBox();
            label3 = new Label();
            listBoxDate = new ListBox();
            label4 = new Label();
            listBoxTaskPriority = new ListBox();
            label5 = new Label();
            listBoxPriority = new ListBox();
            label6 = new Label();
            dateTimePickerTask = new DateTimePicker();
            buttonAdd = new Button();
            buttonRemove = new Button();
            buttonRewrite = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxTask
            // 
            listBoxTask.FormattingEnabled = true;
            listBoxTask.Location = new Point(34, 120);
            listBoxTask.Margin = new Padding(3, 4, 3, 4);
            listBoxTask.Name = "listBoxTask";
            listBoxTask.Size = new Size(175, 324);
            listBoxTask.TabIndex = 0;
            listBoxTask.SelectedIndexChanged += listBoxTask_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 92);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 1;
            label1.Text = "Задача";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 463);
            label2.Name = "label2";
            label2.Size = new Size(160, 20);
            label2.TabIndex = 2;
            label2.Text = "Укажите текст задачи:";
            // 
            // textBoxTextTask
            // 
            textBoxTextTask.Location = new Point(34, 496);
            textBoxTextTask.Margin = new Padding(3, 4, 3, 4);
            textBoxTextTask.Name = "textBoxTextTask";
            textBoxTextTask.Size = new Size(483, 27);
            textBoxTextTask.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 92);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 5;
            label3.Text = "Дата и время";
            // 
            // listBoxDate
            // 
            listBoxDate.FormattingEnabled = true;
            listBoxDate.Location = new Point(232, 120);
            listBoxDate.Margin = new Padding(3, 4, 3, 4);
            listBoxDate.Name = "listBoxDate";
            listBoxDate.Size = new Size(175, 324);
            listBoxDate.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(441, 92);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 7;
            label4.Text = "Приоритет";
            // 
            // listBoxTaskPriority
            // 
            listBoxTaskPriority.FormattingEnabled = true;
            listBoxTaskPriority.Location = new Point(434, 120);
            listBoxTaskPriority.Margin = new Padding(3, 4, 3, 4);
            listBoxTaskPriority.Name = "listBoxTaskPriority";
            listBoxTaskPriority.Size = new Size(175, 324);
            listBoxTaskPriority.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 92);
            label5.Name = "label5";
            label5.Size = new Size(145, 20);
            label5.TabIndex = 8;
            label5.Text = "Укажите приоритет";
            // 
            // listBoxPriority
            // 
            listBoxPriority.FormattingEnabled = true;
            listBoxPriority.Items.AddRange(new object[] { "Низкий", "Средний", "Высокий" });
            listBoxPriority.Location = new Point(33, 127);
            listBoxPriority.Margin = new Padding(3, 4, 3, 4);
            listBoxPriority.Name = "listBoxPriority";
            listBoxPriority.Size = new Size(137, 104);
            listBoxPriority.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 269);
            label6.Name = "label6";
            label6.Size = new Size(161, 20);
            label6.TabIndex = 10;
            label6.Text = "Укажите дату и время";
            // 
            // dateTimePickerTask
            // 
            dateTimePickerTask.Location = new Point(29, 308);
            dateTimePickerTask.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerTask.Name = "dateTimePickerTask";
            dateTimePickerTask.Size = new Size(180, 27);
            dateTimePickerTask.TabIndex = 11;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(29, 369);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(159, 31);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(29, 435);
            buttonRemove.Margin = new Padding(3, 4, 3, 4);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(159, 31);
            buttonRemove.TabIndex = 13;
            buttonRemove.Text = "Удалить";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonRewrite
            // 
            buttonRewrite.Location = new Point(29, 500);
            buttonRewrite.Margin = new Padding(3, 4, 3, 4);
            buttonRewrite.Name = "buttonRewrite";
            buttonRewrite.Size = new Size(159, 31);
            buttonRewrite.TabIndex = 14;
            buttonRewrite.Text = "Перезаписать";
            buttonRewrite.UseVisualStyleBackColor = true;
            buttonRewrite.Click += buttonRewrite_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(buttonRewrite);
            panel1.Controls.Add(listBoxPriority);
            panel1.Controls.Add(buttonRemove);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(dateTimePickerTask);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(659, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 600);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(listBoxTask);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(listBoxTaskPriority);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBoxTextTask);
            panel2.Controls.Add(listBoxDate);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(659, 600);
            panel2.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxTask;
        private Label label1;
        private Label label2;
        private TextBox textBoxTextTask;
        private Label label3;
        private ListBox listBoxDate;
        private Label label4;
        private ListBox listBoxTaskPriority;
        private Label label5;
        private ListBox listBoxPriority;
        private Label label6;
        private DateTimePicker dateTimePickerTask;
        private Button buttonAdd;
        private Button buttonRemove;
        private Button buttonRewrite;
        private Panel panel1;
        private Panel panel2;
    }
}
