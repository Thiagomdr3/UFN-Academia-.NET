using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula29_10_21.src
{
    class DiagonalPrincipaç
    {
        //Escreva um programa em C# que faça atribuição automática dos valores da matriz 3x3, utilizando os índices. Em seguida apresente os valores da diagonal principal.

        /*        Escreva um programa que leia uma matriz de ordem 3 (ou seja, 3x3) e verifique se a
        * soma dos elementos da diagonal principal é igual a soma dos elementos da diagonal secundária.
        */

        public static void Iniciar()
        {

            int[,] matris = new int[3, 3];
            int[,] matris2 = new int[3, 3];
            int soma2 = 0;
            int soma1 = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matris[i, j] = i * j;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine(matris[i, j]);
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("digite o indice para i{0} e j{1}", i, j);
                    matris2[i, j] = int.Parse(Console.ReadLine());
                }
            }



            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        soma1 += matris2[i, j];
                    }
                }
            }



            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i + j == 2)
                    {
                        soma2 += matris2[i, j];
                    }
                }
            }

            if (soma1 == soma2)
            {
                Console.WriteLine("{0} e {1} são iguais", soma1, soma2);
            }
            else
            {
                Console.WriteLine("{0} e {1} são diferentes", soma1, soma2);
            }
        }

    }
}
