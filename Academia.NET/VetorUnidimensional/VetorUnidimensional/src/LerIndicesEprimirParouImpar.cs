using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorUnidimensional.src
{
    class LerIndicesEprimirParouImpar
    {
        /*Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e armazene em um novo vetor primeiramente todos os números pares lidos e
* após todos os ímpares. Exemplo:
a. lê: |7|40|3|9|21|0|63|31|7|22|
b. escreve: |40|0|22|7|3|9|21|63|31|7| */

        public static void Iniciar()
        {
            int[] numeros = new int[10];
            int[] pares, impares;
            int p = 0, imp = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um numero para o indice " + (i + 1));
                numeros[i] = int.Parse(Console.ReadLine());
                if (numeros[i] % 2 == 0)
                {
                    p++;
                }
                else
                {
                    imp++;
                }
            }

            pares = new int[p];
            impares = new int[imp];

            p = 0;
            imp = 0;
            foreach(int index in numeros)
            {
                if (index % 2 == 0)
                {
                    pares[p] = index;
                    p++;
                }
                else
                {
                    impares[imp] = index;
                    imp++;
                }
            }
            Console.WriteLine("Pares:");
            for(int i = 0; i< p; i++)
            {
                Console.WriteLine(pares[i]);
            }

            Console.WriteLine("Impares:");
            for(int i =0; i<imp; i++)
            {
                Console.WriteLine(impares[i]);
            }

        }

    }
}
