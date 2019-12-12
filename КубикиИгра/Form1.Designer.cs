namespace КубикиИгра
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AIPb1 = new System.Windows.Forms.PictureBox();
            this.AIPb2 = new System.Windows.Forms.PictureBox();
            this.AIPb3 = new System.Windows.Forms.PictureBox();
            this.AIPb4 = new System.Windows.Forms.PictureBox();
            this.AIPb5 = new System.Windows.Forms.PictureBox();
            this.UserPb1 = new System.Windows.Forms.PictureBox();
            this.UserPb2 = new System.Windows.Forms.PictureBox();
            this.UserPb3 = new System.Windows.Forms.PictureBox();
            this.UserPb4 = new System.Windows.Forms.PictureBox();
            this.UserPb5 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AIPb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AIPb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AIPb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AIPb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AIPb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPb5)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Бросить Кубики";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 67);
            this.button2.TabIndex = 1;
            this.button2.Text = "Новая Игра";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Игрок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Компьютер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Осталось попыток:5";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(66, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(215, 135);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.AIPb1);
            this.groupBox1.Controls.Add(this.AIPb2);
            this.groupBox1.Controls.Add(this.AIPb3);
            this.groupBox1.Controls.Add(this.AIPb4);
            this.groupBox1.Controls.Add(this.AIPb5);
            this.groupBox1.Controls.Add(this.UserPb1);
            this.groupBox1.Controls.Add(this.UserPb2);
            this.groupBox1.Controls.Add(this.UserPb3);
            this.groupBox1.Controls.Add(this.UserPb4);
            this.groupBox1.Controls.Add(this.UserPb5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(360, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 311);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результаты";
            // 
            // AIPb1
            // 
            this.AIPb1.Location = new System.Drawing.Point(253, 222);
            this.AIPb1.Name = "AIPb1";
            this.AIPb1.Size = new System.Drawing.Size(73, 65);
            this.AIPb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AIPb1.TabIndex = 17;
            this.AIPb1.TabStop = false;
            // 
            // AIPb2
            // 
            this.AIPb2.Location = new System.Drawing.Point(290, 151);
            this.AIPb2.Name = "AIPb2";
            this.AIPb2.Size = new System.Drawing.Size(73, 65);
            this.AIPb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AIPb2.TabIndex = 16;
            this.AIPb2.TabStop = false;
            // 
            // AIPb3
            // 
            this.AIPb3.Location = new System.Drawing.Point(211, 151);
            this.AIPb3.Name = "AIPb3";
            this.AIPb3.Size = new System.Drawing.Size(73, 65);
            this.AIPb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AIPb3.TabIndex = 15;
            this.AIPb3.TabStop = false;
            // 
            // AIPb4
            // 
            this.AIPb4.Location = new System.Drawing.Point(290, 80);
            this.AIPb4.Name = "AIPb4";
            this.AIPb4.Size = new System.Drawing.Size(73, 65);
            this.AIPb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AIPb4.TabIndex = 14;
            this.AIPb4.TabStop = false;
            // 
            // AIPb5
            // 
            this.AIPb5.Location = new System.Drawing.Point(211, 80);
            this.AIPb5.Name = "AIPb5";
            this.AIPb5.Size = new System.Drawing.Size(73, 65);
            this.AIPb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AIPb5.TabIndex = 13;
            this.AIPb5.TabStop = false;
            // 
            // UserPb1
            // 
            this.UserPb1.Location = new System.Drawing.Point(50, 222);
            this.UserPb1.Name = "UserPb1";
            this.UserPb1.Size = new System.Drawing.Size(73, 65);
            this.UserPb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPb1.TabIndex = 12;
            this.UserPb1.TabStop = false;
            // 
            // UserPb2
            // 
            this.UserPb2.Location = new System.Drawing.Point(85, 151);
            this.UserPb2.Name = "UserPb2";
            this.UserPb2.Size = new System.Drawing.Size(73, 65);
            this.UserPb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPb2.TabIndex = 11;
            this.UserPb2.TabStop = false;
            // 
            // UserPb3
            // 
            this.UserPb3.Location = new System.Drawing.Point(6, 151);
            this.UserPb3.Name = "UserPb3";
            this.UserPb3.Size = new System.Drawing.Size(73, 65);
            this.UserPb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPb3.TabIndex = 10;
            this.UserPb3.TabStop = false;
            // 
            // UserPb4
            // 
            this.UserPb4.Location = new System.Drawing.Point(85, 80);
            this.UserPb4.Name = "UserPb4";
            this.UserPb4.Size = new System.Drawing.Size(73, 65);
            this.UserPb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPb4.TabIndex = 9;
            this.UserPb4.TabStop = false;
            // 
            // UserPb5
            // 
            this.UserPb5.Location = new System.Drawing.Point(6, 80);
            this.UserPb5.Name = "UserPb5";
            this.UserPb5.Size = new System.Drawing.Size(73, 65);
            this.UserPb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPb5.TabIndex = 8;
            this.UserPb5.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(213, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Компьютер: 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Игрок: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(758, 402);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AIPb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AIPb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AIPb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AIPb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AIPb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPb5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox AIPb1;
        private System.Windows.Forms.PictureBox AIPb2;
        private System.Windows.Forms.PictureBox AIPb3;
        private System.Windows.Forms.PictureBox AIPb4;
        private System.Windows.Forms.PictureBox AIPb5;
        private System.Windows.Forms.PictureBox UserPb1;
        private System.Windows.Forms.PictureBox UserPb2;
        private System.Windows.Forms.PictureBox UserPb3;
        private System.Windows.Forms.PictureBox UserPb4;
        private System.Windows.Forms.PictureBox UserPb5;
    }
}

