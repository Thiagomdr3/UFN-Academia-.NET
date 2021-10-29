using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorUnidimensional.src
{
    class ArrayContrario
    {
        /* Fazer um algoritmo que leia 5 números e escreva-os na ordem contrária à ordem de leitura. Exemplo:
        a.lê: |7|40|3|9|21|
b.escreve: |21|9|3|40|7|*/

        public static void Iniciar()
        {
            int[] vetor = new int[5];

            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine("digite o valor para o indice " + (i + 1));
                vetor[i] = int.Parse(Console.ReadLine());
            }

            int n = 4, p = 0, imp = 0;
            foreach (int index in vetor)
            {
                n--;
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
