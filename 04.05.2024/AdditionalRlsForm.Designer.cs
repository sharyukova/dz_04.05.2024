namespace _04._05._2024
{
    partial class AdditionalRlsForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(64, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 35);
            this.label6.TabIndex = 15;
            this.label6.Text = "Авторские правила";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label2.Location = new System.Drawing.Point(44, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 36);
            this.label2.TabIndex = 14;
            this.label2.Text = "Все нецензурные выражения заменяются символами.\r\n\r\n";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.checkBox2.Location = new System.Drawing.Point(47, 283);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(401, 24);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "2. Замена мата некоторыми символами\r\n";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label1.Location = new System.Drawing.Point(44, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(797, 54);
            this.label1.TabIndex = 12;
            this.label1.Text = "Все буквы заменяются с \"ё\" на \"е\" (Согласно современным нормам русского языка, не" +
    "обходимое правило для \r\nпостроения грамотного текста).\r\n\r\n";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(47, 159);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(272, 24);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "1. Замена буквы \"ё\" на \"е\"";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // AdditionalRlsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Name = "AdditionalRlsForm";
            this.Text = "Авторские права";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}