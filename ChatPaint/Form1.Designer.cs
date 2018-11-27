namespace ChatPaint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Clear = new System.Windows.Forms.Button();
            this.Color = new System.Windows.Forms.Button();
            this.CrRectangle = new System.Windows.Forms.Button();
            this.CrCircle = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ConnectBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Controls.Add(this.Color);
            this.panel1.Controls.Add(this.CrRectangle);
            this.panel1.Controls.Add(this.CrCircle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 407);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(510, 99);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Color
            // 
            this.Color.Location = new System.Drawing.Point(510, 70);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(75, 23);
            this.Color.TabIndex = 2;
            this.Color.Text = "Color";
            this.Color.UseVisualStyleBackColor = true;
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // CrRectangle
            // 
            this.CrRectangle.Location = new System.Drawing.Point(510, 41);
            this.CrRectangle.Name = "CrRectangle";
            this.CrRectangle.Size = new System.Drawing.Size(75, 23);
            this.CrRectangle.TabIndex = 1;
            this.CrRectangle.Text = "Rectangle";
            this.CrRectangle.UseVisualStyleBackColor = true;
            this.CrRectangle.Click += new System.EventHandler(this.CrRectangle_Click);
            // 
            // CrCircle
            // 
            this.CrCircle.Location = new System.Drawing.Point(510, 12);
            this.CrCircle.Name = "CrCircle";
            this.CrCircle.Size = new System.Drawing.Size(75, 23);
            this.CrCircle.TabIndex = 0;
            this.CrCircle.Text = "Circle";
            this.CrCircle.UseVisualStyleBackColor = true;
            this.CrCircle.Click += new System.EventHandler(this.CrCircle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(411, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите имя";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(411, 174);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.ConnectBtn.TabIndex = 6;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 407);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Color;
        private System.Windows.Forms.Button CrRectangle;
        private System.Windows.Forms.Button CrCircle;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

