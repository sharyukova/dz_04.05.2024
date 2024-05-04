using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _04._05._2024
{
    public partial class TypographerForm : Form
    {
        public TypographerForm()
        {
            InitializeComponent();
        }

        private void основныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputField.Visible = false;
            inputField.ReadOnly = true;
            panelMainRls.Visible = true;
        }

        private void дополнительныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputField.Visible = false;
            panelAddRls.Visible = true;
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение Типограф \n\nРазработано программой Microsoft Visual Studio Community 2022 (64-разрядная версия) - Current\r\nВерсия 17.7.3\r\n\nШарюкова Алина, группа 09-322 ", "Сведения (О программе)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void шрифтТекстаДвухОконToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {                
                inputField.Font = fontDialog.Font;
                outputField.Font = fontDialog.Font;               
            }
        }

        private void шрифтТекстаПервогоОкнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                inputField.Font = fontDialog.Font;
            }
        }

        private void шрифтТекстаВторогоОкнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                outputField.Font = fontDialog.Font;
            }
        }      

       

        //
        private void OKbtn_Click(object sender, EventArgs e)
        {
            panelMainRls.Visible = false;
            inputField.Visible = true;
            inputField.ReadOnly = false;
            outputField.Text = UseMainRules(inputField.Text, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked, checkBox6.Checked, checkBox7.Checked);
        }

        private void checkBox1_MouseEnter(object sender, EventArgs e)
        {
            checkBox1.BackColor = SystemColors.ControlLight;
            infoField.ForeColor = Color.Black;
            infoField.Text = "Все знаки препинания пишутся слева слитно со словом, \nа справа отбиваются пробелом. Тире отбивается пробелами \r\nс двух сторон. Скобки и кавычки пишутся слитно со словами, которые находятся внутри них.\r\n";
        }

        private void checkBox1_MouseLeave(object sender, EventArgs e)
        {
            checkBox1.BackColor = SystemColors.ButtonFace;
            infoField.ForeColor = Color.Gray;
            infoField.Text = "Здесь будет отображаться подробная информация о правилах.";
        }

        private void checkBox2_MouseEnter(object sender, EventArgs e)
        {
            checkBox2.BackColor = SystemColors.ControlLight;
            infoField.ForeColor = Color.Black;
            infoField.Text = "Исключаются все возможности отображения пробела более\nчем одного.\r\n";
        }

        private void checkBox2_MouseLeave(object sender, EventArgs e)
        {
            checkBox2.BackColor = SystemColors.ButtonFace;
            infoField.ForeColor = Color.Gray;
            infoField.Text = "Здесь будет отображаться подробная информация о правилах.";
        }
        private void checkBox3_MouseEnter(object sender, EventArgs e)
        {
            checkBox3.BackColor = SystemColors.ControlLight;
            infoField.ForeColor = Color.Black;
            infoField.Text = "Вместо кавычек «\"» используются кавычки «ёлочки». \nСоздаются они так: «Ёлочки».\r\n";
        }

        private void checkBox3_MouseLeave(object sender, EventArgs e)
        {
            checkBox3.BackColor = SystemColors.ButtonFace;
            infoField.ForeColor = Color.Gray;
            infoField.Text = "Здесь будет отображаться подробная информация о правилах.";
        }

        private void checkBox4_MouseEnter(object sender, EventArgs e)
        {
            checkBox4.BackColor = SystemColors.ControlLight;
            infoField.ForeColor = Color.Black;
            infoField.Text = "Дефис пробелами не отбивается и всегда пишется слитно с \nчастями слова или цифр, которые он разделяет.\r\n";
        }

        private void checkBox4_MouseLeave(object sender, EventArgs e)
        {
            checkBox4.BackColor = SystemColors.ButtonFace;
            infoField.ForeColor = Color.Gray;
            infoField.Text = "Здесь будет отображаться подробная информация о правилах.";
        }

        private void checkBox5_MouseEnter(object sender, EventArgs e)
        {
            checkBox5.BackColor = SystemColors.ControlLight;
            infoField.ForeColor = Color.Black;
            infoField.Text = "Кавычки „лапки“: начинают использоваться, когда в одной конструкции находящейся в кавычках, необходимо написать другую конструкцию в кавычках.";
        }

        private void checkBox5_MouseLeave(object sender, EventArgs e)
        {
            checkBox5.BackColor = SystemColors.ButtonFace;
            infoField.ForeColor = Color.Gray;
            infoField.Text = "Здесь будет отображаться подробная информация о правилах.";
        }       

        private void checkBox6_MouseEnter(object sender, EventArgs e)
        {
            checkBox6.BackColor = SystemColors.ControlLight;
            infoAddField.ForeColor = Color.Black;
            infoAddField.Text = "Все буквы заменяются с \"ё\" на \"е\" (Согласно современным \nнормам русского языка, необходимое правило для \r\nпостроения грамотного текста).\r\n\r\n";
        }

        private void checkBox6_MouseLeave(object sender, EventArgs e)
        {
            checkBox6.BackColor = SystemColors.ButtonFace;
            infoAddField.ForeColor = Color.Gray;
            infoAddField.Text = "Здесь будет отображаться подробная информация о правилах.";
        }

        private void checkBox7_MouseEnter(object sender, EventArgs e)
        {
            checkBox7.BackColor = SystemColors.ControlLight;
            infoAddField.ForeColor = Color.Black;
            infoAddField.Text = "Все нецензурные выражения заменяются символами.\r\n\r\n";
        }

        private void checkBox7_MouseLeave(object sender, EventArgs e)
        {
            checkBox7.BackColor = SystemColors.ButtonFace;
            infoAddField.ForeColor = Color.Gray;
            infoAddField.Text = "Здесь будет отображаться подробная информация о правилах.";
        }

        private void OKbttn_Click(object sender, EventArgs e)
        {
            panelAddRls.Visible = false;
            outputField.Visible = true;
            outputField.Text = UseMainRules(inputField.Text, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked, checkBox6.Checked, checkBox7.Checked);
        }

        private void inputField_TextChanged(object sender, EventArgs e)
        {
            //string str = MainRules.CorrectPunctuationSpaces(inputField.Text);
            outputField.Text = UseMainRules(inputField.Text, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked, checkBox6.Checked, checkBox7.Checked);
        }

        private void первоеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(inputField.Text);
        }

        private void второеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outputField.Text);
        }

        public string UseMainRules(string text, bool rule1, bool rule2, bool rule3, bool rule4, bool rule5, bool myrul1, bool myrul2)
        {
            if (rule1)
            {
                text = MainRules.CorrectPunctuationSpaces(text);
            }

            if (rule2)
            {
                text = MainRules.CorrectSpaces(text);
            }

            if (rule3)
            {
                text = MainRules.CorrectQuotes(text);
            }

            if (rule4)
            {
                text = MainRules.CorrectDashSpaces(text);
            }

            if (rule5)
            {
                text = MainRules.CorrectEllipsis(text);
            }

            if (myrul1)
            {
                text = MyRules.ReplaceE(text);
            }

            if (myrul2)
            {
                text = MyRules.Censor(text);
            }

            return text;
        }

        
    }
}
