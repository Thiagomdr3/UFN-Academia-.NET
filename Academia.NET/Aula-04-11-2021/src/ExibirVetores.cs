﻿using System;
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

        public static void DecomporIndice(int [] vetor)
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

            int iPar = 0;
            Console.WriteLine("_____________________\n" +
                "Vetor Par");
            foreach (int vetorPar in vPar)
            {
                Console.WriteLine($" valor vetor par = {vetorPar} valor original {vetor[iPar]} no indice {iPar} ");
                iPar += 2;
            }

            int iImpar = 1;
            Console.WriteLine("_______________________\n" +
                "Vetor Impar:");
            foreach (int vetorImpar in vImpar)
            {
                Console.WriteLine($" valor no vetor par = {vetorImpar} valor original {vetor[iImpar]} no indice= {iImpar} ");
                iImpar += 2;
            }
        }

        public static void DecomporValor(int[] vetor)
        {
            //Array.Empty<int>();
            int[] vPar = new int[0];
            int[] vImpar = new int[0];

            for(int i = 0; i<10; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Array.Resize(ref vPar, vPar.Length + 1);
                    vPar[vPar.Length - 1] = vetor[i];
                }
                else
                {
                    Array.Resize(ref vImpar, vImpar.Length + 1);
                    vImpar[vImpar.Length - 1] = vetor[i];
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
