using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_3._0
{
    class Ceaser_Crypt  // Цезарь
    {

        private string alf_eng = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string alf_rus = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private string sym = ",.-?!: ";

        public string encrypt(string text, int key)
        {
            string temp_str = "";
            int temp = 0;


            for (int i = 0; i < text.Length; i++)
            {
                // Проверка букв ( англ )
                for (int j = 0; j < alf_eng.Length; j++)
                {
                    if (text[i] == alf_eng[j])
                    {
                        temp = j + key;

                        if (temp >= alf_eng.Length)
                        {
                            temp -= alf_eng.Length;
                        }

                        temp_str = temp_str + alf_eng[temp];
                    }
                }

                // Проверка символов
                for (int k = 0; k < sym.Length; k++)
                {
                    if (text[i] == sym[k])
                    {
                        temp_str = temp_str + sym[k];
                    }
                }

                // Проверка букв ( Рус )
                for (int j = 0; j < alf_rus.Length; j++)
                {
                    if (text[i] == alf_rus[j])
                    {
                        temp = j + key;

                        if (temp >= alf_rus.Length)
                        {
                            temp -= alf_rus.Length;
                        }

                        temp_str = temp_str + alf_rus[temp];
                    }
                }
            }
            return temp_str;
        }

        public string decrypt(string text, int key)
        {

            string temp_str = "";
            int temp = 0;

            for (int i = 0; i < text.Length; i++)
            {
                // Проверка символов
                for (int k = 0; k < sym.Length; k++)
                {
                    if (text[i] == sym[k])
                    {
                        temp_str = temp_str + sym[k];
                    }
                }

                // Проверка букв ( Англ )
                for (int j = 0; j < alf_eng.Length; j++)
                {
                    if (text[i] == alf_eng[j])
                    {
                        temp = j - key;

                        if (temp < 0)
                            temp += alf_eng.Length;

                        temp_str = temp_str + alf_eng[temp];
                    }
                }

                // Проверка букв ( Рус )
                for (int j = 0; j < alf_rus.Length; j++)
                {
                    if (text[i] == alf_rus[j])
                    {
                        temp = j - key;

                        if (temp < 0)
                            temp += alf_rus.Length;

                        temp_str = temp_str + alf_rus[temp];
                    }
                }
            }
            return temp_str;
        }

    }
}
