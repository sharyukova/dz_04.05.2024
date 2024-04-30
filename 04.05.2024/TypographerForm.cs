using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            MainRlsForm mainRlsForm = new MainRlsForm();
            mainRlsForm.Show();
        }

        private void дополнительныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdditionalRlsForm additional = new AdditionalRlsForm();
            additional.Show();
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

        private void inputField_TextChanged(object sender, EventArgs e)
        {
            outputField.Text = inputField.Text;
        }
    }
}
