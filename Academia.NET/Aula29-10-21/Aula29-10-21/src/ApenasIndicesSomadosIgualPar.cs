using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula29_10_21.src
{
    class ApenasIndicesSomadosIgualPar
    {
        public static void Iniciar()
        {
            int[,] matriz = new int[3, 4];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("digite um numero para guardar em i{0} j{1}", i, j);
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write(matriz[i, j]+"   ");
                    }
                    
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == 1)
                    {
                        matriz[i, j] *= 2;
                    }
                    if (i == 2)
                    {
                        matriz[i, j] *= 3;
                    }
                }
            }
            Console.WriteLine("____________________________________");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matriz[i, j]+"     ");
                }
                Console.WriteLine();
            }
        }
    }
}
