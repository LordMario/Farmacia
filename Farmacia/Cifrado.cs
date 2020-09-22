using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Farmacia
{
    class Cifrado
    {      
        public Cifrado() { }

        public string Cifrar(string pwd)
        {
            char[] frase = new char[pwd.Length];
            frase = pwd.ToCharArray();

            for (int i = 0; i < desplazamiento; i++)
            {


                if ((frase[pwd.Length - 1] >= 65 && frase[pwd.Length - 1] < 90) || (frase[pwd.Length - 1] >= 97 && frase[pwd.Length - 1] < 122))
                {
                    frase[pwd.Length - 1]++;
                }
                else if (frase[pwd.Length - 1] == 90)
                {
                    frase[pwd.Length - 1] = 'A';
                }
                else if (frase[pwd.Length - 1] == 122)
                {
                    frase[pwd.Length - 1] = 'a';
                }
            }

            return pwd = new string(frase);
        }

        public string Descifrar(string pwd)
        {
            char[] frase = new char[pwd.Length];
            frase = pwd.ToCharArray();

            for (int i = 0; i < pwd.Length; i++)
            {

                if ((frase[i] > 65 && frase[i] <= 90) || (frase[i] > 97 && frase[i] <= 122))
                {
                    for (int j = 0; j < desplazamiento; j++)
                    {
                        frase[i]--;
                    }
                }
                else if (frase[i] == 65)
                {
                    frase[i] = 'A';
                }
                else if (frase[i] == 97)
                {
                    frase[i] = 'a';
                }
            }

            return pwd = new string(frase);
        }

        private int desplazamiento = 5;
    }
}
