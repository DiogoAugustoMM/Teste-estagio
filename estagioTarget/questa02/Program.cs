using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao2
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int verifica;
            string frase = "";
            do
            {
                try
                {
                    Console.WriteLine("Escreva uma frase");
                    frase = Console.ReadLine();
                    verifica = 0;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nEscreva uma frase valida!!!");
                    verifica = 1;
                }
            } while (verifica == 1);

            char[] fraseMinuscula = frase.ToLower().ToCharArray();
            int contador = 0;
            for (int i = 0; i < fraseMinuscula.Length; i++)
            {
                if (fraseMinuscula[i] == 'a')
                {
                    contador++;
                }
            }

            Console.WriteLine("A letra 'a' aparece na frase {0} vezes ", contador);

        }
    }
}