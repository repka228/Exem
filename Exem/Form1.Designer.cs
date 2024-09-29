namespace Exem
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
            buttonTask1_1 = new Button();
            labelArraySize = new Label();
            buttonTask1_2 = new Button();
            textBoxTarget = new TextBox();
            label1 = new Label();
            textBoxTask1_1 = new TextBox();
            textBoxTask1_2 = new TextBox();
            labelAnswerTask1_1 = new Label();
            labelAnswerTask1_2 = new Label();
            textBoxArraySize = new TextBox();
            listBoxTask4 = new ListBox();
            buttonMethod1 = new Button();
            buttonMethod2 = new Button();
            buttonInvokeMethod2 = new Button();
            buttonInvokeMethod1 = new Button();
            buttonMethod1_1Del = new Button();
            buttonMethod1_2Del = new Button();
            saveFileDialog1 = new SaveFileDialog();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // buttonTask1_1
            // 
            buttonTask1_1.Location = new Point(12, 70);
            buttonTask1_1.Name = "buttonTask1_1";
            buttonTask1_1.Size = new Size(75, 23);
            buttonTask1_1.TabIndex = 0;
            buttonTask1_1.Text = "Задание 1";
            buttonTask1_1.UseVisualStyleBackColor = true;
            buttonTask1_1.Click += ButtonTask1_1_Click;
            // 
            // labelArraySize
            // 
            labelArraySize.AutoSize = true;
            labelArraySize.Location = new Point(12, 23);
            labelArraySize.Name = "labelArraySize";
            labelArraySize.Size = new Size(96, 15);
            labelArraySize.TabIndex = 2;
            labelArraySize.Text = "Размер массива";
            // 
            // buttonTask1_2
            // 
            buttonTask1_2.Location = new Point(12, 143);
            buttonTask1_2.Name = "buttonTask1_2";
            buttonTask1_2.Size = new Size(75, 23);
            buttonTask1_2.TabIndex = 3;
            buttonTask1_2.Text = "Задание 2";
            buttonTask1_2.UseVisualStyleBackColor = true;
            buttonTask1_2.Click += ButtonTask1_2_Click;
            // 
            // textBoxTarget
            // 
            textBoxTarget.Location = new Point(12, 114);
            textBoxTarget.Name = "textBoxTarget";
            textBoxTarget.Size = new Size(100, 23);
            textBoxTarget.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 96);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Значение";
            // 
            // textBoxTask1_1
            // 
            textBoxTask1_1.Location = new Point(223, 41);
            textBoxTask1_1.Name = "textBoxTask1_1";
            textBoxTask1_1.Size = new Size(262, 23);
            textBoxTask1_1.TabIndex = 6;
            // 
            // textBoxTask1_2
            // 
            textBoxTask1_2.Location = new Point(223, 114);
            textBoxTask1_2.Name = "textBoxTask1_2";
            textBoxTask1_2.Size = new Size(262, 23);
            textBoxTask1_2.TabIndex = 7;
            // 
            // labelAnswerTask1_1
            // 
            labelAnswerTask1_1.AutoSize = true;
            labelAnswerTask1_1.Location = new Point(223, 23);
            labelAnswerTask1_1.Name = "labelAnswerTask1_1";
            labelAnswerTask1_1.Size = new Size(38, 15);
            labelAnswerTask1_1.TabIndex = 8;
            labelAnswerTask1_1.Text = "Ответ";
            // 
            // labelAnswerTask1_2
            // 
            labelAnswerTask1_2.AutoSize = true;
            labelAnswerTask1_2.Location = new Point(223, 96);
            labelAnswerTask1_2.Name = "labelAnswerTask1_2";
            labelAnswerTask1_2.Size = new Size(38, 15);
            labelAnswerTask1_2.TabIndex = 9;
            labelAnswerTask1_2.Text = "Ответ";
            // 
            // textBoxArraySize
            // 
            textBoxArraySize.Location = new Point(12, 41);
            textBoxArraySize.Name = "textBoxArraySize";
            textBoxArraySize.Size = new Size(100, 23);
            textBoxArraySize.TabIndex = 10;
            // 
            // listBoxTask4
            // 
            listBoxTask4.FormattingEnabled = true;
            listBoxTask4.ItemHeight = 15;
            listBoxTask4.Location = new Point(12, 315);
            listBoxTask4.Name = "listBoxTask4";
            listBoxTask4.Size = new Size(338, 94);
            listBoxTask4.TabIndex = 11;
            // 
            // buttonMethod1
            // 
            buttonMethod1.Location = new Point(518, 40);
            buttonMethod1.Name = "buttonMethod1";
            buttonMethod1.Size = new Size(118, 23);
            buttonMethod1.TabIndex = 12;
            buttonMethod1.Text = "Добавить 1 метод";
            buttonMethod1.UseVisualStyleBackColor = true;
            buttonMethod1.Click += buttonMethod1_Click;
            // 
            // buttonMethod2
            // 
            buttonMethod2.Location = new Point(518, 69);
            buttonMethod2.Name = "buttonMethod2";
            buttonMethod2.Size = new Size(118, 23);
            buttonMethod2.TabIndex = 13;
            buttonMethod2.Text = "Вызвать 1 метод";
            buttonMethod2.UseVisualStyleBackColor = true;
            buttonMethod2.Click += buttonInvokeMethod1_Click;
            // 
            // buttonInvokeMethod2
            // 
            buttonInvokeMethod2.Location = new Point(642, 70);
            buttonInvokeMethod2.Name = "buttonInvokeMethod2";
            buttonInvokeMethod2.Size = new Size(118, 23);
            buttonInvokeMethod2.TabIndex = 14;
            buttonInvokeMethod2.Text = "Вызвать 2 метод";
            buttonInvokeMethod2.UseVisualStyleBackColor = true;
            buttonInvokeMethod2.Click += buttonInvokeMethod2_Click;
            // 
            // buttonInvokeMethod1
            // 
            buttonInvokeMethod1.Location = new Point(642, 41);
            buttonInvokeMethod1.Name = "buttonInvokeMethod1";
            buttonInvokeMethod1.Size = new Size(118, 23);
            buttonInvokeMethod1.TabIndex = 15;
            buttonInvokeMethod1.Text = "Добавить 2 метод";
            buttonInvokeMethod1.UseVisualStyleBackColor = true;
            buttonInvokeMethod1.Click += buttonMethod2_Click;
            // 
            // buttonMethod1_1Del
            // 
            buttonMethod1_1Del.Location = new Point(518, 96);
            buttonMethod1_1Del.Name = "buttonMethod1_1Del";
            buttonMethod1_1Del.Size = new Size(118, 23);
            buttonMethod1_1Del.TabIndex = 16;
            buttonMethod1_1Del.Text = "Удалить метод 1";
            buttonMethod1_1Del.UseVisualStyleBackColor = true;
            buttonMethod1_1Del.Click += buttonMethod1_1Del_Click;
            // 
            // buttonMethod1_2Del
            // 
            buttonMethod1_2Del.Location = new Point(642, 96);
            buttonMethod1_2Del.Name = "buttonMethod1_2Del";
            buttonMethod1_2Del.Size = new Size(118, 23);
            buttonMethod1_2Del.TabIndex = 17;
            buttonMethod1_2Del.Text = "Удалить метод 2";
            buttonMethod1_2Del.UseVisualStyleBackColor = true;
            buttonMethod1_2Del.Click += buttonMethod1_2Del_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(713, 415);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 18;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(buttonMethod1_2Del);
            Controls.Add(buttonMethod1_1Del);
            Controls.Add(buttonInvokeMethod1);
            Controls.Add(buttonInvokeMethod2);
            Controls.Add(buttonMethod2);
            Controls.Add(buttonMethod1);
            Controls.Add(listBoxTask4);
            Controls.Add(textBoxArraySize);
            Controls.Add(labelAnswerTask1_2);
            Controls.Add(labelAnswerTask1_1);
            Controls.Add(textBoxTask1_2);
            Controls.Add(textBoxTask1_1);
            Controls.Add(label1);
            Controls.Add(textBoxTarget);
            Controls.Add(buttonTask1_2);
            Controls.Add(labelArraySize);
            Controls.Add(buttonTask1_1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonTask1_1;
        private Label labelArraySize;
        private Button buttonTask1_2;
        private TextBox textBoxTarget;
        private Label label1;
        private TextBox textBoxTask1_1;
        private TextBox textBoxTask1_2;
        private Label labelAnswerTask1_1;
        private Label labelAnswerTask1_2;
        private TextBox textBoxArraySize;
        private ListBox listBoxTask4;
        private Button buttonMethod1;
        private Button buttonMethod2;
        private Button buttonInvokeMethod2;
        private Button buttonInvokeMethod1;
        private Button buttonMethod1_1Del;
        private Button buttonMethod1_2Del;
        private SaveFileDialog saveFileDialog1;
        private Button buttonSave;
    }
}
