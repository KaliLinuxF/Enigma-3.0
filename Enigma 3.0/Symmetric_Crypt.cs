using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_3._0
{
    class Symmetric_Crypt
    {

        private int[] key;
        private int OneKey { get; set; }
        private const int fixkey = 150;

        public Symmetric_Crypt(int[] key)
        {
            this.key = new int[5];
            this.key = key;

            OneKey = (key[0] + key[1] + key[2] + key[3] + key[4]) / 5;
        }

        public string encrypt(string text)
        {
            int temp = 0;
            string temp_str = "";

            for (int i = 0; i < text.Length; i++)
            {
                temp = fixkey + OneKey;
                temp_str = temp_str + (char)((int)text[i] + temp);
            }
            return temp_str;
        }

        public string decrypt(string text)
        {
            int temp = 0;
            string temp_str = "";

            for (int i = 0; i < text.Length; i++)
            {
                temp = fixkey + OneKey;
                temp_str = temp_str + (char)((int)text[i] - temp);
            }
            return temp_str;
        }

    }
}
