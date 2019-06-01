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
    public partial class Symmetric_Form : Form
    {
        public Symmetric_Form()
        {
            InitializeComponent();
        }

        private void encrypt_button(object sender, EventArgs e)
        {
            textBox_result.Clear();

            try
            {

                if (Convert.ToInt32(textBox_key.Text) < 10000 || Convert.ToInt32(textBox_key.Text) > 99999)
                {
                    MessageBox.Show("Ключ должен состоять из пяти чисел", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    textBox_key.Text.Split(' ');
                    int[] arr = new int[5];
                    for (int i = 0; i < textBox_key.Text.Length; i++)
                    {
                        int j = 0;
                        if (textBox_key.Text[i] != ' ')
                        {
                            arr[j] = Convert.ToInt32(textBox_key.Text[i]);
                        }
                        j++;
                    }

                    Symmetric_Crypt sc = new Symmetric_Crypt(arr);
                    for (int i = 0; i < textBox_utext.Lines.Length; i++)
                    {
                        textBox_result.AppendText(sc.encrypt(textBox_utext.Lines[i]) + Environment.NewLine);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Вводите только цифры!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void decrypt_button(object sender, EventArgs e)
        {

            textBox_result.Clear();

            try
            {
                if (Convert.ToInt32(textBox_key.Text) < 10000 || Convert.ToInt32(textBox_key.Text) > 99999)
                {
                    MessageBox.Show("Ключ должен состоять из пяти чисел", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    textBox_key.Text.Split(' ');

                    int[] arr = new int[5];

                    for (int i = 0; i < textBox_key.Text.Length; i++)
                    {
                        int j = 0;
                        if (textBox_key.Text[i] != ' ')
                        {
                            arr[j] = Convert.ToInt32(textBox_key.Text[i]);
                        }
                        j++;
                    }

                    Symmetric_Crypt sc = new Symmetric_Crypt(arr);

                    for (int i = 0; i < textBox_utext.Lines.Length; i++)
                    {
                        textBox_result.AppendText(sc.decrypt(textBox_utext.Lines[i]) + Environment.NewLine);
                    }

                }
            }
            catch
            {

                MessageBox.Show("Вводите только цифры!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_result.Clear();
            textBox_utext.Clear();
            textBox_key.Clear();
        }

        private void Symmetric_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            menu_form m = new menu_form();
            m.Show();
        }

        private void textBox_key_Enter(object sender, EventArgs e)
        {
            textBox_key.Clear();
        }
    }
}
