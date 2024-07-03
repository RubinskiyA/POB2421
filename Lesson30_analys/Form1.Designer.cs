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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.buttonComplete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonLower = new System.Windows.Forms.RadioButton();
            this.radioButtonUpper = new System.Windows.Forms.RadioButton();
            this.textBoxSubString = new System.Windows.Forms.TextBox();
            this.checkBoxFind = new System.Windows.Forms.CheckBox();
            this.checkBoxCount = new System.Windows.Forms.CheckBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelOutput = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxAll);
            this.panel1.Controls.Add(this.buttonComplete);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.textBoxInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 461);
            this.panel1.TabIndex = 3;
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Location = new System.Drawing.Point(35, 200);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(94, 19);
            this.checkBoxAll.TabIndex = 4;
            this.checkBoxAll.Text = "Выбрать все";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxAll_CheckedChanged);
            // 
            // buttonComplete
            // 
            this.buttonComplete.Location = new System.Drawing.Point(84, 415);
            this.buttonComplete.Name = "buttonComplete";
            this.buttonComplete.Size = new System.Drawing.Size(119, 34);
            this.buttonComplete.TabIndex = 3;
            this.buttonComplete.Text = "Выполнить";
            this.buttonComplete.UseVisualStyleBackColor = true;
            this.buttonComplete.Click += new System.EventHandler(this.buttonComplete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonLower);
            this.groupBox1.Controls.Add(this.radioButtonUpper);
            this.groupBox1.Controls.Add(this.textBoxSubString);
            this.groupBox1.Controls.Add(this.checkBoxFind);
            this.groupBox1.Controls.Add(this.checkBoxCount);
            this.groupBox1.Location = new System.Drawing.Point(30, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 167);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Методы";
            // 
            // radioButtonLower
            // 
            this.radioButtonLower.AutoSize = true;
            this.radioButtonLower.Location = new System.Drawing.Point(23, 139);
            this.radioButtonLower.Name = "radioButtonLower";
            this.radioButtonLower.Size = new System.Drawing.Size(117, 19);
            this.radioButtonLower.TabIndex = 4;
            this.radioButtonLower.TabStop = true;
            this.radioButtonLower.Text = "Нижний регистр";
            this.radioButtonLower.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpper
            // 
            this.radioButtonUpper.AutoSize = true;
            this.radioButtonUpper.Location = new System.Drawing.Point(23, 114);
            this.radioButtonUpper.Name = "radioButtonUpper";
            this.radioButtonUpper.Size = new System.Drawing.Size(118, 19);
            this.radioButtonUpper.TabIndex = 3;
            this.radioButtonUpper.TabStop = true;
            this.radioButtonUpper.Text = "Верхний регистр";
            this.radioButtonUpper.UseVisualStyleBackColor = true;
            // 
            // textBoxSubString
            // 
            this.textBoxSubString.Location = new System.Drawing.Point(6, 79);
            this.textBoxSubString.Multiline = true;
            this.textBoxSubString.Name = "textBoxSubString";
            this.textBoxSubString.Size = new System.Drawing.Size(226, 29);
            this.textBoxSubString.TabIndex = 2;
            // 
            // checkBoxFind
            // 
            this.checkBoxFind.AutoSize = true;
            this.checkBoxFind.Location = new System.Drawing.Point(24, 54);
            this.checkBoxFind.Name = "checkBoxFind";
            this.checkBoxFind.Size = new System.Drawing.Size(85, 19);
            this.checkBoxFind.TabIndex = 1;
            this.checkBoxFind.Text = "Подстрока";
            this.checkBoxFind.UseVisualStyleBackColor = true;
            this.checkBoxFind.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxCount
            // 
            this.checkBoxCount.AutoSize = true;
            this.checkBoxCount.Location = new System.Drawing.Point(24, 29);
            this.checkBoxCount.Name = "checkBoxCount";
            this.checkBoxCount.Size = new System.Drawing.Size(149, 19);
            this.checkBoxCount.TabIndex = 0;
            this.checkBoxCount.Text = "Количество символов";
            this.checkBoxCount.UseVisualStyleBackColor = true;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(30, 46);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(238, 130);
            this.textBoxInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите текст для анализа: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelOutput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(297, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 461);
            this.panel2.TabIndex = 0;
            // 
            // labelOutput
            // 
            this.labelOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOutput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOutput.Location = new System.Drawing.Point(0, 0);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(287, 461);
            this.labelOutput.TabIndex = 0;
            // 
            // Analisator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "Analisator";
            this.Text = "Analisator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

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