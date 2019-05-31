using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma_3._0
{
    public partial class Morze : Form
    {
        public Morze()
        {
            InitializeComponent();
        }

        private int rus_eng = 0;

        private void button_encrypt_Click(object sender, EventArgs e)
        {
            Morze_Crypt mz = new Morze_Crypt();

            textBox_result.Clear();

            for (int i = 0; i < textBox_utext.Lines.Length; i++)
            {
                textBox_result.AppendText(mz.encrypt(textBox_utext.Lines[i], rus_eng) + Environment.NewLine);
            }

        }

        private void button_swap_Click(object sender, EventArgs e)
        {
            textBox_utext.Clear();

            for (int i = 0; i < textBox_result.Lines.Length; i++)
            {
                textBox_utext.AppendText(textBox_result.Lines[i] + Environment.NewLine);
            }

            textBox_result.Clear();
        }

        private void button_decrypt_Click(object sender, EventArgs e)
        {
            Morze_Crypt mz = new Morze_Crypt();

            textBox_result.Clear();

            for (int i = 0; i < textBox_utext.Lines.Length; i++)
            {
                textBox_result.AppendText(mz.decrypt(textBox_utext.Lines[i], rus_eng) + Environment.NewLine);
            }

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_result.Clear();
            textBox_utext.Clear();
            radioButton_rus.Checked = false;
            radioButton_eng.Checked = false;
        }

        private void radioButton_rus_CheckedChanged(object sender, EventArgs e)
        {
            rus_eng = 1;
        }

        private void radioButton_eng_CheckedChanged(object sender, EventArgs e)
        {
            rus_eng = 2;
        }

        private void Morze_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu_form menu = new menu_form();
            this.Hide();
            menu.Show();
        }
    }
}
