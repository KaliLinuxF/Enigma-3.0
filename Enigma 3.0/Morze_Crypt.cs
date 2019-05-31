using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma_3._0
{
    class Morze_Crypt
    {
        private char[] alf_rus = new char[] {            'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И',
                                                        'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                                        'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ы', 'Ь',
                                                        'Э', 'Ю', 'Я'};

        private string[] codeMorse_rus = new string[] {         "*–", "–***", "*––", "––*",
                                                        "–**", "*", "***–", "––**",
                                                        "**", "*–––", "–*–", "*–**",
                                                        "––", "–*", "–––", "*––*",
                                                        "*–*", "***", "–", "**–",
                                                        "**–*", "****", "–*–*",
                                                        "–––*", "––––", "−−*−",
                                                        "−*−−", "−**−", "**−**",
                                                        "**−−", "*−*−", "*−−−−" };

        private char[] alf_eng = new char[] {              'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
                                                       'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R',
                                                       'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        private string[] codeMorse_eng = new string[] { "*-", "-***", "-*-*", "-**", "*", "**-*", "--*", "****",
                                                    "**", "*---", "-*-", "*-**", "--", "-*", "---", "*--*",
                                                    "--*-", "*-*", "***", "-", "**-", "***-", "*--", "-**-",
                                                    "-*--", "--**" };


        public string encrypt(string text, int rus_eng)
            {
                string temp_str = "";
                text = text.ToUpper();

                switch (rus_eng)
                {
                    case 1: // Проверка на русский
                        {
                            for (int i = 0; i < text.Length; i++)
                            {
                                for (int j = 0; j < alf_rus.Length; j++)
                                {
                                    if (text[i] == alf_rus[j])
                                    {
                                        temp_str += codeMorse_rus[j] + " ";
                                    }
                                }
                            }
                            break;
                        }
                    case 2: // Проверка на эльфийский
                        {
                            for (int i = 0; i < text.Length; i++)
                            {
                                for (int j = 0; j < alf_eng.Length; j++)
                                {
                                    if (text[i] == alf_eng[j])
                                    {
                                        temp_str += codeMorse_eng[j] + " ";
                                    }
                                }
                            }

                            break;
                        }
                    default: // не забыть реализовать ошибку на Windows Form
                        {
                        MessageBox.Show("Выбирете один из языков!","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                }

                return temp_str;

            }

        public string decrypt(string text, int rus_eng)
            {
                string temp_str = "";
                text = text.ToUpper();
                string[] utext = text.Split(' ');

                switch (rus_eng)
                {
                    case 1: // Проверка на русский
                        {
                            for (int i = 0; i < utext.Length; i++)
                            {
                                for (int j = 0; j < codeMorse_rus.Length; j++)
                                {
                                    if (utext[i] == codeMorse_rus[j])
                                    {
                                        temp_str += alf_rus[j] + " ";
                                    }
                                }
                            } // Проверка на русский

                            break;
                        }
                    case 2: // Проверка на эльфийский
                        {
                            for (int i = 0; i < utext.Length; i++)
                            {
                                for (int j = 0; j < codeMorse_eng.Length; j++)
                                {
                                    if (utext[i] == codeMorse_eng[j])
                                    {
                                        temp_str += alf_eng[j] + " ";
                                    }
                                }
                            } // Проверка на эльфийский

                            break;
                        }
                    default: // не забыть реализовать ошибку на Windows Form
                        {
                        MessageBox.Show("Выбирете один из языков!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                        }
                }



                return temp_str;
            }
    }
}
