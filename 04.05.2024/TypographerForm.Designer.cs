namespace _04._05._2024
{
    partial class TypographerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypographerForm));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.inputField = new System.Windows.Forms.RichTextBox();
            this.outputField = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.правилаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.основныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дополнительныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтТекстаДвухОконToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтТекстаПервогоОкнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтТекстаВторогоОкнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 26);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(823, 4);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.inputField);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.outputField);
            this.splitContainer1.Size = new System.Drawing.Size(823, 523);
            this.splitContainer1.SplitterDistance = 407;
            this.splitContainer1.TabIndex = 1;
            // 
            // inputField
            // 
            this.inputField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.inputField.Location = new System.Drawing.Point(0, 0);
            this.inputField.Name = "inputField";
            this.inputField.Size = new System.Drawing.Size(407, 523);
            this.inputField.TabIndex = 0;
            this.inputField.Text = "";
            this.inputField.TextChanged += new System.EventHandler(this.inputField_TextChanged);
            // 
            // outputField
            // 
            this.outputField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.outputField.Location = new System.Drawing.Point(0, 0);
            this.outputField.Name = "outputField";
            this.outputField.ReadOnly = true;
            this.outputField.Size = new System.Drawing.Size(412, 523);
            this.outputField.TabIndex = 1;
            this.outputField.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 26);
            this.panel1.TabIndex = 2;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правилаToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(823, 28);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // правилаToolStripMenuItem
            // 
            this.правилаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.основныеToolStripMenuItem,
            this.дополнительныеToolStripMenuItem});
            this.правилаToolStripMenuItem.Name = "правилаToolStripMenuItem";
            this.правилаToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.правилаToolStripMenuItem.Text = "Правила";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шрифтТекстаДвухОконToolStripMenuItem,
            this.шрифтТекстаПервогоОкнаToolStripMenuItem,
            this.шрифтТекстаВторогоОкнаToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.справкаToolStripMenuItem.Text = "Сведения (О программе)";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // основныеToolStripMenuItem
            // 
            this.основныеToolStripMenuItem.Name = "основныеToolStripMenuItem";
            this.основныеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.основныеToolStripMenuItem.Text = "Основные";
            this.основныеToolStripMenuItem.Click += new System.EventHandler(this.основныеToolStripMenuItem_Click);
            // 
            // дополнительныеToolStripMenuItem
            // 
            this.дополнительныеToolStripMenuItem.Name = "дополнительныеToolStripMenuItem";
            this.дополнительныеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.дополнительныеToolStripMenuItem.Text = "Дополнительные";
            this.дополнительныеToolStripMenuItem.Click += new System.EventHandler(this.дополнительныеToolStripMenuItem_Click);
            // 
            // шрифтТекстаДвухОконToolStripMenuItem
            // 
            this.шрифтТекстаДвухОконToolStripMenuItem.Name = "шрифтТекстаДвухОконToolStripMenuItem";
            this.шрифтТекстаДвухОконToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.шрифтТекстаДвухОконToolStripMenuItem.Text = "Шрифт текста двух окон";
            this.шрифтТекстаДвухОконToolStripMenuItem.Click += new System.EventHandler(this.шрифтТекстаДвухОконToolStripMenuItem_Click);
            // 
            // шрифтТекстаПервогоОкнаToolStripMenuItem
            // 
            this.шрифтТекстаПервогоОкнаToolStripMenuItem.Name = "шрифтТекстаПервогоОкнаToolStripMenuItem";
            this.шрифтТекстаПервогоОкнаToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.шрифтТекстаПервогоОкнаToolStripMenuItem.Text = "Шрифт текста первого окна";
            this.шрифтТекстаПервогоОкнаToolStripMenuItem.Click += new System.EventHandler(this.шрифтТекстаПервогоОкнаToolStripMenuItem_Click);
            // 
            // шрифтТекстаВторогоОкнаToolStripMenuItem
            // 
            this.шрифтТекстаВторогоОкнаToolStripMenuItem.Name = "шрифтТекстаВторогоОкнаToolStripMenuItem";
            this.шрифтТекстаВторогоОкнаToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.шрифтТекстаВторогоОкнаToolStripMenuItem.Text = "Шрифт текста второго окна";
            this.шрифтТекстаВторогоОкнаToolStripMenuItem.Click += new System.EventHandler(this.шрифтТекстаВторогоОкнаToolStripMenuItem_Click);
            // 
            // TypographerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(823, 553);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "TypographerForm";
            this.Text = "Типограф";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox inputField;
        private System.Windows.Forms.RichTextBox outputField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem правилаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem основныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дополнительныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтТекстаДвухОконToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтТекстаПервогоОкнаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтТекстаВторогоОкнаToolStripMenuItem;
    }
}