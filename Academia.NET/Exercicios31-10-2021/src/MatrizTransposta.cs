using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios31_10_2021.src
{
    class MatrizTransposta
    {
        /*Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3. Transpor uma matriz significa transformar suas linhas em colunas e vice-versa.//*/

        public static void Iniciar()
        {
            int[,] matriz = new int[3, 4];
            int[,] transposta = new int[4, 3];

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Mariz (3x4)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("_______________________________________");
            

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i,j]=i*j +j+3;
                    Console.Write(" {0}  ",matriz[i,j]);
                }
                Console.WriteLine();

            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTransposta (4x3)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("_______________________________________");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    transposta[i, j] = matriz[j, i];
                    Console.Write("  {0}  ", transposta[i, j]);
                }
                Console.WriteLine();
            }

        }
    }

}
