using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.IO;

namespace lab6
{
    public class Caesar
    {
        public Caesar() { }

        private int searchInAlphabeth(String alphabet, char desiredChar)
        {

            char[] chars = alphabet.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (Char.ToUpper(desiredChar) == Char.ToUpper(chars[i]))
                    return i;
            }
            return -1;
        }

        public void cifrarCesar(string frase, int distancia, string fileName)
        {
            String alfabeto = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            String nuevaFrase = "";

            char[] original = frase.ToCharArray();

            for (int i = 0; i < original.Length; i++)
            {
                char originalChar = original[i];

                if (originalChar == ' ')
                {
                    nuevaFrase += originalChar;
                }
                else
                {
                    int shift = searchInAlphabeth(alfabeto, originalChar) + distancia;
                    char newChar = ' ';

                    while (shift >= alfabeto.Length)
                    {
                        shift = shift - alfabeto.Length;
                    }

                    if (Char.IsUpper(originalChar))
                    {
                        newChar = alfabeto.ElementAt(shift);
                    }
                    else
                    {
                        newChar = Char.ToLower(alfabeto.ElementAt(shift));
                    }
                    nuevaFrase += newChar;
                }

            }

            //escribir archivo 
            string folder = @"C:\LABORATORIO6\";
            string fullPath = folder + fileName;
            // crear el directorio
            DirectoryInfo directory = Directory.CreateDirectory(folder);

            using (StreamWriter file = new StreamWriter(fullPath))
            {
                file.WriteLine(nuevaFrase);
                file.Close();
            }
        }
    }
}
