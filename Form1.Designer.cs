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
            this.pictureBox1rectangularIsometry = new System.Windows.Forms.PictureBox();
            this.textBox1dots = new System.Windows.Forms.TextBox();
            this.button1draw = new System.Windows.Forms.Button();
            this.textBox1lines = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1rectangularIsometry)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1rectangularIsometry
            // 
            this.pictureBox1rectangularIsometry.Location = new System.Drawing.Point(276, 66);
            this.pictureBox1rectangularIsometry.Name = "pictureBox1rectangularIsometry";
            this.pictureBox1rectangularIsometry.Size = new System.Drawing.Size(341, 278);
            this.pictureBox1rectangularIsometry.TabIndex = 0;
            this.pictureBox1rectangularIsometry.TabStop = false;
            // 
            // textBox1dots
            // 
            this.textBox1dots.Location = new System.Drawing.Point(12, 12);
            this.textBox1dots.Multiline = true;
            this.textBox1dots.Name = "textBox1dots";
            this.textBox1dots.Size = new System.Drawing.Size(93, 262);
            this.textBox1dots.TabIndex = 1;
            this.textBox1dots.Text = "-5,-5,-5\r\n-5,-5,5\r\n-5,5,-5\r\n-5,5,5\r\n5,-5,-5\r\n5,-5,5\r\n5,5,-5\r\n5,5,5";
            // 
            // button1draw
            // 
            this.button1draw.Location = new System.Drawing.Point(276, 12);
            this.button1draw.Name = "button1draw";
            this.button1draw.Size = new System.Drawing.Size(341, 48);
            this.button1draw.TabIndex = 2;
            this.button1draw.Text = "button1draw";
            this.button1draw.UseVisualStyleBackColor = true;
            this.button1draw.Click += new System.EventHandler(this.button1draw_Click);
            // 
            // textBox1lines
            // 
            this.textBox1lines.Location = new System.Drawing.Point(111, 12);
            this.textBox1lines.Multiline = true;
            this.textBox1lines.Name = "textBox1lines";
            this.textBox1lines.Size = new System.Drawing.Size(93, 262);
            this.textBox1lines.TabIndex = 3;
            this.textBox1lines.Text = "1,2\r\n3,4\r\n5,6\r\n7,8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 630);
            this.Controls.Add(this.textBox1lines);
            this.Controls.Add(this.button1draw);
            this.Controls.Add(this.textBox1dots);
            this.Controls.Add(this.pictureBox1rectangularIsometry);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1rectangularIsometry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1rectangularIsometry;
        private System.Windows.Forms.TextBox textBox1dots;
        private System.Windows.Forms.Button button1draw;
        private System.Windows.Forms.TextBox textBox1lines;
    }
}

