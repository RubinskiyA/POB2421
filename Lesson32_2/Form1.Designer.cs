namespace Lesson32_2
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
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.radioButtonReverse = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonPolindrom = new System.Windows.Forms.RadioButton();
            this.groupBoxReg = new System.Windows.Forms.GroupBox();
            this.radioButtonLower = new System.Windows.Forms.RadioButton();
            this.radioButtonUpper = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.groupBoxFind = new System.Windows.Forms.GroupBox();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxReg.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(25, 27);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(396, 71);
            this.textBoxText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите строку:";
            // 
            // labelResult
            // 
            this.labelResult.Location = new System.Drawing.Point(25, 99);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(396, 119);
            this.labelResult.TabIndex = 2;
            // 
            // radioButtonReverse
            // 
            this.radioButtonReverse.AutoSize = true;
            this.radioButtonReverse.Location = new System.Drawing.Point(11, 44);
            this.radioButtonReverse.Name = "radioButtonReverse";
            this.radioButtonReverse.Size = new System.Drawing.Size(126, 19);
            this.radioButtonReverse.TabIndex = 4;
            this.radioButtonReverse.TabStop = true;
            this.radioButtonReverse.Text = "Переворот строки";
            this.radioButtonReverse.UseVisualStyleBackColor = true;
            this.radioButtonReverse.CheckedChanged += new System.EventHandler(this.radioButtonReverse_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonReverse);
            this.groupBox1.Controls.Add(this.radioButtonPolindrom);
            this.groupBox1.Location = new System.Drawing.Point(30, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 69);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Палиндром";
            // 
            // radioButtonPolindrom
            // 
            this.radioButtonPolindrom.AutoSize = true;
            this.radioButtonPolindrom.Location = new System.Drawing.Point(11, 22);
            this.radioButtonPolindrom.Name = "radioButtonPolindrom";
            this.radioButtonPolindrom.Size = new System.Drawing.Size(95, 19);
            this.radioButtonPolindrom.TabIndex = 4;
            this.radioButtonPolindrom.TabStop = true;
            this.radioButtonPolindrom.Text = "Палиндром?";
            this.radioButtonPolindrom.UseVisualStyleBackColor = true;
            this.radioButtonPolindrom.CheckedChanged += new System.EventHandler(this.radioButtonPolindrom_CheckedChanged);
            // 
            // groupBoxReg
            // 
            this.groupBoxReg.Controls.Add(this.radioButtonLower);
            this.groupBoxReg.Controls.Add(this.radioButtonUpper);
            this.groupBoxReg.Location = new System.Drawing.Point(30, 296);
            this.groupBoxReg.Name = "groupBoxReg";
            this.groupBoxReg.Size = new System.Drawing.Size(200, 100);
            this.groupBoxReg.TabIndex = 11;
            this.groupBoxReg.TabStop = false;
            this.groupBoxReg.Text = "Верхний\\нижний";
            // 
            // radioButtonLower
            // 
            this.radioButtonLower.AutoSize = true;
            this.radioButtonLower.Location = new System.Drawing.Point(8, 55);
            this.radioButtonLower.Name = "radioButtonLower";
            this.radioButtonLower.Size = new System.Drawing.Size(117, 19);
            this.radioButtonLower.TabIndex = 1;
            this.radioButtonLower.TabStop = true;
            this.radioButtonLower.Text = "Нижний регистр";
            this.radioButtonLower.UseVisualStyleBackColor = true;
            this.radioButtonLower.CheckedChanged += new System.EventHandler(this.radioButtonLower_CheckedChanged);
            // 
            // radioButtonUpper
            // 
            this.radioButtonUpper.AutoSize = true;
            this.radioButtonUpper.Location = new System.Drawing.Point(8, 30);
            this.radioButtonUpper.Name = "radioButtonUpper";
            this.radioButtonUpper.Size = new System.Drawing.Size(118, 19);
            this.radioButtonUpper.TabIndex = 0;
            this.radioButtonUpper.TabStop = true;
            this.radioButtonUpper.Text = "Верхний регистр";
            this.radioButtonUpper.UseVisualStyleBackColor = true;
            this.radioButtonUpper.CheckedChanged += new System.EventHandler(this.radioButtonUpper_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxIndex);
            this.groupBox3.Location = new System.Drawing.Point(257, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(181, 98);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Введите индекс";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(22, 29);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(100, 23);
            this.textBoxIndex.TabIndex = 0;
            this.textBoxIndex.TextChanged += new System.EventHandler(this.textBoxIndex_TextChanged);
            // 
            // groupBoxFind
            // 
            this.groupBoxFind.Controls.Add(this.textBoxFind);
            this.groupBoxFind.Location = new System.Drawing.Point(30, 411);
            this.groupBoxFind.Name = "groupBoxFind";
            this.groupBoxFind.Size = new System.Drawing.Size(408, 100);
            this.groupBoxFind.TabIndex = 13;
            this.groupBoxFind.TabStop = false;
            this.groupBoxFind.Text = "Введите слово для поиска";
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(11, 46);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(380, 23);
            this.textBoxFind.TabIndex = 0;
            this.textBoxFind.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 512);
            this.Controls.Add(this.groupBoxFind);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxReg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxText);
            this.Name = "Form1";
            this.Text = "Theme27_2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxReg.ResumeLayout(false);
            this.groupBoxReg.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxFind.ResumeLayout(false);
            this.groupBoxFind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxText;
        private Label label1;
        private Label labelResult;
        private RadioButton radioButtonReverse;
        private GroupBox groupBox1;
        private RadioButton radioButtonPolindrom;
        private GroupBox groupBoxReg;
        private RadioButton radioButtonLower;
        private RadioButton radioButtonUpper;
        private GroupBox groupBox3;
        private TextBox textBoxIndex;
        private GroupBox groupBoxFind;
        private TextBox textBoxFind;
    }
}