using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorUnidimensional.src
{
    class SubstituirIndiceNulo
    {
        public static void Iniciar()
        {
            int[] vetor = new int[20];
            int[] nvetor = new int[20];

            int zeros = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Digite o valor para o indice "+(i+1));
                vetor[1] = int.Parse(Console.ReadLine());
            }


            for(int i = 0; i < 20; i++)
            {
                if (vetor[i] == 0)
                {
                    nvetor[zeros] = 2;
                    zeros++;
                }
            }

            foreach (int index in vetor)
            {
                Console.WriteLine("Vetor inteiro "+index);
            }

            foreach(int index in nvetor)
            {
                Console.WriteLine("Vetor dos numeros substituidos "+index);
            }
        }
    }
}
