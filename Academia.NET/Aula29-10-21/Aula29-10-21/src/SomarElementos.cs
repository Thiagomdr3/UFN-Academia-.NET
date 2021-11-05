using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula29_10_21.src
{
    class SomarElementos
    {

        //ler uma matriz 4x4 e somar os elementos
        public static void Iniciar()
        {
            int[,] matriz = new int[4, 4];
            int soma = 0;

            for(int i = 0; i<4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Digite um numero para o indice i{0} j{1}", i+1, j+1);
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    soma += matriz[i, j];
                }
            }

            Console.WriteLine("Somatório = "+soma);
        }

    }
}
