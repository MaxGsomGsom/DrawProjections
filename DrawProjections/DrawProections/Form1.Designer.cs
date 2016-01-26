namespace DrawProections
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1draw = new System.Windows.Forms.PictureBox();
            this.textBox1dots = new System.Windows.Forms.TextBox();
            this.button1draw = new System.Windows.Forms.Button();
            this.textBox1lines = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1draw)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1draw
            // 
            this.pictureBox1draw.BackColor = System.Drawing.Color.White;
            this.pictureBox1draw.Location = new System.Drawing.Point(253, 9);
            this.pictureBox1draw.Name = "pictureBox1draw";
            this.pictureBox1draw.Size = new System.Drawing.Size(784, 669);
            this.pictureBox1draw.TabIndex = 0;
            this.pictureBox1draw.TabStop = false;
            // 
            // textBox1dots
            // 
            this.textBox1dots.Location = new System.Drawing.Point(12, 55);
            this.textBox1dots.Multiline = true;
            this.textBox1dots.Name = "textBox1dots";
            this.textBox1dots.Size = new System.Drawing.Size(110, 331);
            this.textBox1dots.TabIndex = 1;
            this.textBox1dots.Text = "150, 200, 100\r\n150, 200, 0\r\n150, 0, 100\r\n150, 0, 0\r\n0, 200, 100\r\n0, 200, 0\r\n0, 0," +
    " 100\r\n0, 0, 0";
            // 
            // button1draw
            // 
            this.button1draw.Location = new System.Drawing.Point(12, 630);
            this.button1draw.Name = "button1draw";
            this.button1draw.Size = new System.Drawing.Size(235, 48);
            this.button1draw.TabIndex = 2;
            this.button1draw.Text = "Нарисовать";
            this.button1draw.UseVisualStyleBackColor = true;
            this.button1draw.Click += new System.EventHandler(this.button1draw_Click);
            // 
            // textBox1lines
            // 
            this.textBox1lines.Location = new System.Drawing.Point(137, 55);
            this.textBox1lines.Multiline = true;
            this.textBox1lines.Name = "textBox1lines";
            this.textBox1lines.Size = new System.Drawing.Size(110, 331);
            this.textBox1lines.TabIndex = 3;
            this.textBox1lines.Text = "8, 4\r\n8, 7\r\n8, 6\r\n1, 2\r\n1, 3\r\n1, 5\r\n2, 4\r\n3, 7\r\n3, 4\r\n5, 7\r\n6, 2\r\n8, 4\r\n8, 7\r\n8, " +
    "6\r\n1, 2\r\n1, 3\r\n1, 5\r\n2, 4\r\n3, 7\r\n3, 4\r\n5, 7\r\n6, 2\r\n6, 5";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(206, 21);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Прямоугольная изометрия";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(12, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 232);
            this.panel1.TabIndex = 5;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(13, 66);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(193, 38);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.Text = "Горизонтальная \r\nкосоугольная изометрия";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(199, 21);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "Прямоугольная диметрия";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Координаты \r\nточек:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Отрезки между \r\nточками:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(13, 110);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(193, 38);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.Text = "Фронтальная \r\nкосоугольная изометрия";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(13, 154);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(186, 38);
            this.radioButton5.TabIndex = 8;
            this.radioButton5.Text = "Фронтальная \r\nкосоугольная диметрия";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 690);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1lines);
            this.Controls.Add(this.button1draw);
            this.Controls.Add(this.textBox1dots);
            this.Controls.Add(this.pictureBox1draw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проекции";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1draw)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1draw;
        private System.Windows.Forms.TextBox textBox1dots;
        private System.Windows.Forms.Button button1draw;
        private System.Windows.Forms.TextBox textBox1lines;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
    }
}

