namespace _04._05._2024
{
    partial class MainRlsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainRlsForm));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(31, 123);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(383, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "1. Правильная расстановка пробелов";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label1.Location = new System.Drawing.Point(28, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(841, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label2.Location = new System.Drawing.Point(28, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(529, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Исключаются все возможности отображения пробела более чем одного.\r\n";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.checkBox2.Location = new System.Drawing.Point(31, 247);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(378, 24);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "2. Использовать только один пробел\r\n";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label3.Location = new System.Drawing.Point(28, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(608, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Вместо кавычек «\"» используются кавычки «ёлочки». Создаются они так: «Ёлочки».\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.checkBox3.Location = new System.Drawing.Point(31, 370);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(167, 24);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "3. \" \"   >>>   « »\r\n";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label4.Location = new System.Drawing.Point(27, 529);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(781, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дефис пробелами не отбивается и всегда пишется слитно с частями слова или цифр, к" +
    "оторые он разделяет.\r\n";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.checkBox4.Location = new System.Drawing.Point(30, 490);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(261, 24);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "4. Дефис \"без пробелов\"";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label5.Location = new System.Drawing.Point(27, 661);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(855, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "С числами используется исключительно знак минуса: \"−\". В арифметических конструкц" +
    "иях знаки операций отбиваются \r\nпробелом с двух сторон. Например «5 − 4 = 1».";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.checkBox5.Location = new System.Drawing.Point(30, 622);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(168, 24);
            this.checkBox5.TabIndex = 8;
            this.checkBox5.Text = "5. Знак минуса";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(40, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 35);
            this.label6.TabIndex = 10;
            this.label6.Text = "Основные правила";
            // 
            // MainRlsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 761);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Name = "MainRlsForm";
            this.Text = "Основные правила";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label6;
    }
}