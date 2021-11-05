using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula29_10_21.src
{
    class MatrizOrdem5
    {
        /*Escreva um programa que leia uma matriz de ordem 5 e verifique se os elementos da diagonal principal (da esquerda para a direita) são os mesmos da diagonal secundária (direita pra esquerda).*/

        public static void Iniciar()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            int[,] matriz = new int[5, 5];
            int aux1 = 0, aux2 = 0, indice1 = 0, indice2 = 0;
            int condicao1 = 0, condicao2 = 0;
            int t = 1,contador=0;


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                   if(i==j || i + j == 4)
                    {
                        switch (t)
                        {
                            case 1:
                                matriz[i, j] = 32;
                                break;
                            case 2:
                                matriz[i, j] = 78;
                                break;
                            case 3:
                                matriz[i, j] = 78;
                                break;
                            case 4:
                                matriz[i, j] = 78;
                                break;
                            case 5:
                                matriz[i, j] = 328;
                                break;
                            case 6:
                                matriz[i, j] = 57;
                                break;
                            case 7:
                                matriz[i, j] = 57;
                                break;
                            case 8:
                                matriz[i, j] = 328;
                                break;
                            case 9:
                                matriz[i, j] = 328;
                                break;
                            default:
                                matriz[i, j] = i + j;
                                break;
                        }
                        t++;
                    }
                    else
                    {
                        matriz[i, j] = i + j;
                    }

                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j)
                    {
                        aux1 = matriz[i, j];
                        indice1 = int.Parse(i.ToString() + j.ToString());
                        condicao1 = 1;

                    }
                    if (i + j == 4)
                    {
                        aux2 = matriz[i, j];
                        indice2 = int.Parse(i.ToString() + j.ToString());
                        condicao2 = 1;
                    }

                    if (aux1 == aux2 && condicao1 == 1 && condicao2 == 1)
                    {
                        Console.WriteLine("indice {0} = {1} e indice {2} = {3}", indice1, aux1, indice2, aux2);
                        condicao1 = 0; condicao2 = 0;contador++;
                    }
                }
            }

            if (contador == 5)
            {
                Console.WriteLine("\n_________________________________________________________\n");
                Console.WriteLine("A condição ocorreu");
            }

            Console.WriteLine("______________________________________________\n\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Abaixo a matriz completa:\n");
            Console.ForegroundColor = ConsoleColor.White;
            for(int i =0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if (j == 4)
                    {
                        Console.Write(matriz[i, j]);
                    }
                    else
                    {
                        Console.Write(matriz[i, j] + "     -      ");
                    }
                }

                Console.WriteLine();
            }

        }
    }
}
