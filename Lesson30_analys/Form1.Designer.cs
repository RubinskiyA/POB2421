namespace Lesson30_analys
{
    partial class Analisator
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
            panel1 = new Panel();
            checkBoxAll = new CheckBox();
            buttonComplete = new Button();
            groupBox1 = new GroupBox();
            radioButtonLower = new RadioButton();
            radioButtonUpper = new RadioButton();
            textBoxSubString = new TextBox();
            checkBoxFind = new CheckBox();
            checkBoxCount = new CheckBox();
            textBoxInput = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            labelOutput = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxAll);
            panel1.Controls.Add(buttonComplete);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(textBoxInput);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 604);
            panel1.TabIndex = 3;
            // 
            // checkBoxAll
            // 
            checkBoxAll.AutoSize = true;
            checkBoxAll.Location = new Point(40, 267);
            checkBoxAll.Margin = new Padding(3, 4, 3, 4);
            checkBoxAll.Name = "checkBoxAll";
            checkBoxAll.Size = new Size(118, 24);
            checkBoxAll.TabIndex = 4;
            checkBoxAll.Text = "Выбрать все";
            checkBoxAll.UseVisualStyleBackColor = true;
            checkBoxAll.CheckedChanged += checkBoxAll_CheckedChanged;
            // 
            // buttonComplete
            // 
            buttonComplete.Location = new Point(96, 553);
            buttonComplete.Margin = new Padding(3, 4, 3, 4);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new Size(136, 45);
            buttonComplete.TabIndex = 3;
            buttonComplete.Text = "Выполнить";
            buttonComplete.UseVisualStyleBackColor = true;
            buttonComplete.Click += buttonComplete_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonLower);
            groupBox1.Controls.Add(radioButtonUpper);
            groupBox1.Controls.Add(textBoxSubString);
            groupBox1.Controls.Add(checkBoxFind);
            groupBox1.Controls.Add(checkBoxCount);
            groupBox1.Location = new Point(34, 297);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(272, 223);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Методы";
            // 
            // radioButtonLower
            // 
            radioButtonLower.AutoSize = true;
            radioButtonLower.Location = new Point(26, 185);
            radioButtonLower.Margin = new Padding(3, 4, 3, 4);
            radioButtonLower.Name = "radioButtonLower";
            radioButtonLower.Size = new Size(146, 24);
            radioButtonLower.TabIndex = 4;
            radioButtonLower.TabStop = true;
            radioButtonLower.Text = "Нижний регистр";
            radioButtonLower.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpper
            // 
            radioButtonUpper.AutoSize = true;
            radioButtonUpper.Location = new Point(26, 152);
            radioButtonUpper.Margin = new Padding(3, 4, 3, 4);
            radioButtonUpper.Name = "radioButtonUpper";
            radioButtonUpper.Size = new Size(148, 24);
            radioButtonUpper.TabIndex = 3;
            radioButtonUpper.TabStop = true;
            radioButtonUpper.Text = "Верхний регистр";
            radioButtonUpper.UseVisualStyleBackColor = true;
            // 
            // textBoxSubString
            // 
            textBoxSubString.Location = new Point(7, 105);
            textBoxSubString.Margin = new Padding(3, 4, 3, 4);
            textBoxSubString.Multiline = true;
            textBoxSubString.Name = "textBoxSubString";
            textBoxSubString.Size = new Size(258, 37);
            textBoxSubString.TabIndex = 2;
            // 
            // checkBoxFind
            // 
            checkBoxFind.AutoSize = true;
            checkBoxFind.Location = new Point(27, 72);
            checkBoxFind.Margin = new Padding(3, 4, 3, 4);
            checkBoxFind.Name = "checkBoxFind";
            checkBoxFind.Size = new Size(105, 24);
            checkBoxFind.TabIndex = 1;
            checkBoxFind.Text = "Подстрока";
            checkBoxFind.UseVisualStyleBackColor = true;
            checkBoxFind.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBoxCount
            // 
            checkBoxCount.AutoSize = true;
            checkBoxCount.Location = new Point(27, 39);
            checkBoxCount.Margin = new Padding(3, 4, 3, 4);
            checkBoxCount.Name = "checkBoxCount";
            checkBoxCount.Size = new Size(185, 24);
            checkBoxCount.TabIndex = 0;
            checkBoxCount.Text = "Количество символов";
            checkBoxCount.UseVisualStyleBackColor = true;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(34, 61);
            textBoxInput.Margin = new Padding(3, 4, 3, 4);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(271, 172);
            textBoxInput.TabIndex = 1;
            textBoxInput.TextChanged += textBoxInput_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 37);
            label1.Name = "label1";
            label1.Size = new Size(199, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите текст для анализа: ";
            // 
            // panel2
            // 
            panel2.Controls.Add(labelOutput);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(337, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(328, 604);
            panel2.TabIndex = 0;
            // 
            // labelOutput
            // 
            labelOutput.Dock = DockStyle.Fill;
            labelOutput.Font = new Font("Segoe UI", 15F);
            labelOutput.Location = new Point(0, 0);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(328, 604);
            labelOutput.TabIndex = 0;
            // 
            // Analisator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 604);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(683, 651);
            MinimumSize = new Size(340, 251);
            Name = "Analisator";
            Text = "Analisator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox1;
        private CheckBox checkBoxFind;
        private CheckBox checkBoxCount;
        private TextBox textBoxInput;
        private Label label1;
        private TextBox textBoxSubString;
        private CheckBox checkBoxAll;
        private Button buttonComplete;
        private RadioButton radioButtonLower;
        private RadioButton radioButtonUpper;
        private Label labelOutput;
    }
}