namespace Lesson28
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
            buttonAdd = new Button();
            buttonSub = new Button();
            buttonMulti = new Button();
            buttonDiv = new Button();
            textBoxFirstVar = new TextBox();
            labelFirstVar = new Label();
            labelSecondVar = new Label();
            textBoxSecondVar = new TextBox();
            labelResult = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(25, 243);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(45, 45);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSub
            // 
            buttonSub.Location = new Point(86, 243);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(45, 45);
            buttonSub.TabIndex = 1;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = true;
            buttonSub.Click += buttonSub_Click;
            // 
            // buttonMulti
            // 
            buttonMulti.Location = new Point(151, 243);
            buttonMulti.Name = "buttonMulti";
            buttonMulti.Size = new Size(45, 45);
            buttonMulti.TabIndex = 2;
            buttonMulti.Text = "*";
            buttonMulti.UseVisualStyleBackColor = true;
            buttonMulti.Click += buttonMulti_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.Location = new Point(218, 243);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(45, 45);
            buttonDiv.TabIndex = 3;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = true;
            buttonDiv.Click += buttonDiv_Click;
            // 
            // textBoxFirstVar
            // 
            textBoxFirstVar.Location = new Point(25, 80);
            textBoxFirstVar.Name = "textBoxFirstVar";
            textBoxFirstVar.Size = new Size(100, 23);
            textBoxFirstVar.TabIndex = 4;
            textBoxFirstVar.Enter += textBoxFirstVar_Enter;
            textBoxFirstVar.KeyPress += textBoxFirstVar_KeyPress;
            // 
            // labelFirstVar
            // 
            labelFirstVar.AutoSize = true;
            labelFirstVar.Location = new Point(25, 47);
            labelFirstVar.Name = "labelFirstVar";
            labelFirstVar.Size = new Size(132, 15);
            labelFirstVar.TabIndex = 5;
            labelFirstVar.Text = "Введите первое число:";
            // 
            // labelSecondVar
            // 
            labelSecondVar.AutoSize = true;
            labelSecondVar.Location = new Point(26, 133);
            labelSecondVar.Name = "labelSecondVar";
            labelSecondVar.Size = new Size(131, 15);
            labelSecondVar.TabIndex = 6;
            labelSecondVar.Text = "Введите второе число:";
            // 
            // textBoxSecondVar
            // 
            textBoxSecondVar.Location = new Point(25, 185);
            textBoxSecondVar.Name = "textBoxSecondVar";
            textBoxSecondVar.Size = new Size(100, 23);
            textBoxSecondVar.TabIndex = 7;
            textBoxSecondVar.KeyPress += textBoxSecondVar_KeyPress;
            // 
            // labelResult
            // 
            labelResult.Font = new Font("Calibri", 30.35F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelResult.Location = new Point(176, 80);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(96, 160);
            labelResult.TabIndex = 8;
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(26, 308);
            button1.Name = "button1";
            button1.Size = new Size(132, 23);
            button1.TabIndex = 9;
            button1.Text = "Очистить поля ввода";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 361);
            Controls.Add(button1);
            Controls.Add(labelResult);
            Controls.Add(textBoxSecondVar);
            Controls.Add(labelSecondVar);
            Controls.Add(labelFirstVar);
            Controls.Add(textBoxFirstVar);
            Controls.Add(buttonDiv);
            Controls.Add(buttonMulti);
            Controls.Add(buttonSub);
            Controls.Add(buttonAdd);
            Name = "Form1";
            Text = "Мое первое приложение";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private Button buttonSub;
        private Button buttonMulti;
        private Button buttonDiv;
        private TextBox textBoxFirstVar;
        private Label labelFirstVar;
        private Label labelSecondVar;
        private TextBox textBoxSecondVar;
        private Label labelResult;
        private Button button1;
    }
}
