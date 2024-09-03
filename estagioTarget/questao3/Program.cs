using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace questao3
{
    internal class Program
    {


        static void Main(string[] args)
        {

            int indice = 12;
            int soma = 0;
            int k = 1;

            while (k < indice)
            {
                k++;
                soma = soma + k;
            }

            Console.WriteLine(soma);


        }
    }
}
