using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorUnidimensional.src
{
    class SomaVetores
    {

        /*3. Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a soma dos elementos da mesma posição,
* armazenando o resultado em um outro vetor.
*/
        public static void Iniciar()
        {
            int[] numeros1 = new int[20];
            int[] numeros2 = new int[20];

            for (int i1 = 0; i1 < 2; i1++)
            {

                for (int i2 = 0; i2 < 20; i2++)
                {
                    Console.WriteLine("Digite o valor para o indice "+i2+" para o vetor"+(i1+1));
                    if (i1 == 0)
                    {
                        numeros1[i2] = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        numeros2[i2] = int.Parse(Console.ReadLine());
                    }
                }
            }
            int n = 0;
            foreach(int index in numeros1)
            {
                Console.WriteLine("{0} * {1} = {2} ", index, numeros2[n], index * numeros2[n]); ;
                n++;
            }
        }
    }
}
