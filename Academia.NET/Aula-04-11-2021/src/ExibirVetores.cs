using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_11_2021.src
{
    class ExibirVetores
    {
        public static void Inversa(int[] vetor)
        {
            for(int i =9; i >= 0; i--)
            {
                Console.WriteLine($"O valor no indice {i} é {vetor[i]}");
            }
        }

        public static int[] DecomporIndice(int [] vetor, int parImpar)
        {
            int[] vPar = new int[5];
            int[] vImpar = new int[5];
            int v = 0, u = 0;

            for(int i = 0; i<10; i++)
            {
                if (i % 2 == 0)
                {
                    vPar[v] = vetor[i];
                    v++;               
                }
                else
                {
                    vImpar[u] = vetor[i];
                    u++;
                }

            }

            if (parImpar == 1)
            {
                return vImpar;
            }
            else
            {
                return vPar;
            }
            
        }

        public static void DecomporValor(int[] vetor)
        {
            int[] vPar = Array.Empty<int>();
            int[] vImpar = Array.Empty<int>();

            for (int i = 0; i<10; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Array.Resize(ref vPar, vPar.Length + 1);
                    vPar[^1] = vetor[i];
                }
                else
                {
                    Array.Resize(ref vImpar, vImpar.Length + 1);
                    vImpar[^1] = vetor[i];
                }
            }
            Console.WriteLine("_____________________\n" +
                "Vetor Par");
            foreach(int vetorPar in vPar)
            {
                Console.WriteLine(vetorPar);
            }
            Console.WriteLine("_______________________\n" +
                "Vetor Impar:");
            foreach(int vetorImpar in vImpar)
            {
                Console.WriteLine(vetorImpar);
            }
        }
    }
}
