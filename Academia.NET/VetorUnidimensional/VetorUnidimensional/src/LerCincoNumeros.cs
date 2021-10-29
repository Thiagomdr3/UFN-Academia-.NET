using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorUnidimensional.src
{
    class LerCincoNumeros
    {
        public static void Iniciar()
        {
            int[] vetor = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("digite o valor para o indice " + (i + 1));
                vetor[i] = int.Parse(Console.ReadLine());
            }

            int n = 0, p = 0, imp = 0;
            foreach (int index in vetor)
            {
                n++;
                if (index % 2 == 0)
                {
                    p++;
                    Console.WriteLine(" o numero " + index + " no indice " + n + " é par");
                }
                else
                {
                    imp++;
                    Console.WriteLine(" o numero " + index + " no indice " + n + " é impar");
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\ntemos {0} numeros pares e {1} impares dentro do vetor", p, imp);
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
