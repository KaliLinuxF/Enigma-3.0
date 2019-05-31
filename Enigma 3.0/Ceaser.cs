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
    public partial class Ceaser_Form : Form
    {
        public Ceaser_Form()
        {
            InitializeComponent();
        }
       
        private void Clear_button(object sender, EventArgs e)
        {
            textBox_utext.Clear();
            textBox_result.Clear();
            textBox_key.Clear();
        }

        private void Encrypt_button(object sender, EventArgs e)
        {
            Ceaser_Crypt cs = new Ceaser_Crypt();

            textBox_result.Clear();
            int key = 0;

            key = Convert.ToInt32(textBox_key.Text);
            if(key < 1 || key > 32 )
            {
                MessageBox.Show("Ключ должен иметь значение от 1 до 32", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < textBox_utext.Lines.Length; i++)
                {
                    textBox_result.AppendText(cs.encrypt(textBox_utext.Lines[i], key) + Environment.NewLine);

                }
            }
           
        }

        private void swap_button(object sender, EventArgs e)
        {
            textBox_utext.Clear();

            for (int i = 0; i < textBox_result.Lines.Length; i++)
            {
                textBox_utext.AppendText(textBox_result.Lines[i] + Environment.NewLine);
            }

            textBox_result.Clear();
        }

        private void decrypt_button(object sender, EventArgs e)
        {
            Ceaser_Crypt cs = new Ceaser_Crypt();
            int key = 0;
            textBox_result.Clear();

            try
            {
                key = Convert.ToInt32(textBox_key.Text);
            }
            catch
            {
                MessageBox.Show("Вводите только цифры!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
            if(key < 1 || key > 32)
            {
                MessageBox.Show("Ключ должен иметь значение от 1 до 32", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < textBox_utext.Lines.Length; i++)
                {
                    textBox_result.AppendText(cs.decrypt(textBox_utext.Lines[i], key) + Environment.NewLine);

                }
            }
           
        }

        private void Ceaser_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu_form menu = new menu_form();
            menu.Show();
        }

        private void textBox_result_Enter(object sender, EventArgs e)
        {
            textBox_key.Clear();
        }
    }
}
