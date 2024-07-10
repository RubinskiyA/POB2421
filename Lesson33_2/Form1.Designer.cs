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
            listBoxTask.ItemHeight = 15;
            listBoxTask.Location = new Point(30, 90);
            listBoxTask.Name = "listBoxTask";
            listBoxTask.Size = new Size(154, 244);
            listBoxTask.TabIndex = 0;
            listBoxTask.SelectedIndexChanged += listBoxTask_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 69);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Задача";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 347);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 2;
            label2.Text = "Укажите текст задачи:";
            // 
            // textBoxTextTask
            // 
            textBoxTextTask.Location = new Point(30, 372);
            textBoxTextTask.Name = "textBoxTextTask";
            textBoxTextTask.Size = new Size(423, 23);
            textBoxTextTask.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 69);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 5;
            label3.Text = "Дата и время";
            // 
            // listBoxDate
            // 
            listBoxDate.FormattingEnabled = true;
            listBoxDate.ItemHeight = 15;
            listBoxDate.Location = new Point(203, 90);
            listBoxDate.Name = "listBoxDate";
            listBoxDate.Size = new Size(154, 244);
            listBoxDate.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(386, 69);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 7;
            label4.Text = "Приоритет";
            // 
            // listBoxTaskPriority
            // 
            listBoxTaskPriority.FormattingEnabled = true;
            listBoxTaskPriority.ItemHeight = 15;
            listBoxTaskPriority.Location = new Point(380, 90);
            listBoxTaskPriority.Name = "listBoxTaskPriority";
            listBoxTaskPriority.Size = new Size(154, 244);
            listBoxTaskPriority.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 69);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 8;
            label5.Text = "Укажите приоритет";
            // 
            // listBoxPriority
            // 
            listBoxPriority.FormattingEnabled = true;
            listBoxPriority.ItemHeight = 15;
            listBoxPriority.Items.AddRange(new object[] { "Низкий", "Средний", "Высокий" });
            listBoxPriority.Location = new Point(29, 95);
            listBoxPriority.Name = "listBoxPriority";
            listBoxPriority.Size = new Size(120, 79);
            listBoxPriority.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 202);
            label6.Name = "label6";
            label6.Size = new Size(126, 15);
            label6.TabIndex = 10;
            label6.Text = "Укажите дату и время";
            // 
            // dateTimePickerTask
            // 
            dateTimePickerTask.Location = new Point(25, 231);
            dateTimePickerTask.Name = "dateTimePickerTask";
            dateTimePickerTask.Size = new Size(158, 23);
            dateTimePickerTask.TabIndex = 11;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(25, 277);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(139, 23);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(25, 326);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(139, 23);
            buttonRemove.TabIndex = 13;
            buttonRemove.Text = "Удалить";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonRewrite
            // 
            buttonRewrite.Location = new Point(25, 375);
            buttonRewrite.Name = "buttonRewrite";
            buttonRewrite.Size = new Size(139, 23);
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
            panel1.Location = new Point(577, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(195, 450);
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
            panel2.Name = "panel2";
            panel2.Size = new Size(577, 450);
            panel2.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
