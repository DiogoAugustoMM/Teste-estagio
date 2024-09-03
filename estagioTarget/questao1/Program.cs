using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao1
{
    internal class Program
    {

        static int VerificaNumero(int[] vetor, int num)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == num)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] fibonacci = new int[20];

            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 2; i < fibonacci.Length; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            int numDesejado = 1;
            int verifica;
            do
            {
                try
                {
                    Console.WriteLine("Qual numero deseja verificar?");
                    numDesejado = int.Parse(Console.ReadLine());
                    verifica = 0;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nPor favor adicione um numero!!!");
                    verifica = 1;
                }
            } while (verifica == 1);
            if (VerificaNumero(fibonacci, numDesejado) != -1)
            {
                Console.WriteLine("O numero esta localizado na {0}° posição da sequencia de Fibonacci", VerificaNumero(fibonacci, numDesejado) + 1);
            }
            else Console.WriteLine("O numero não se encontra entre os 20 primeiros numeros da sequencia de Fibonacci");

        }
    }
}

