using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_08_11_21.src
{
    class Exercicio2
    {
        //2 . Escreva um programa que leia uma matriz de inteiros com ordem 10x10 e por meio de funções faça o que se pede:

        //a.Exiba o menor elemento da matriz
        //b.Encontre e exiba o maior elemento de cada uma das linhas da matriz

        public static void Iniciar()
        {
            Console.Clear();
            int[,] matriz = new int[10, 10];
            int[] maiores = new int[10];
            int menor;
            
            matriz = Construir(matriz);

            Mostrar(matriz);
            menor = MostrarMenor(matriz);
            maiores = MostrarMaiores(matriz, maiores);
        }

        public static int[,] Construir(int[,] matriz)
        {


            Random rdm = new();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matriz[i, j] = rdm.Next(1, 101);
                }
            }

            return matriz;
        }

        public static void Mostrar(int[,] matriz)
        {
            for(int i = 0; i<10; i++)
            {
                for(int j = 0; j< 10; j++)
                {
                    if(matriz[i,j].ToString().Length == 1)
                    {
                        Console.Write($"|   {matriz[i, j]}  ");
                    }else if (matriz[i, j].ToString().Length == 2)
                    {
                        Console.Write($"|  {matriz[i, j]}  ");
                    }
                    else
                    {
                        Console.Write($"| {matriz[i, j]}  ");
                    }
                    
                }
                Console.WriteLine("\n________________________________________________________________________");
            }
        }

        public static int MostrarMenor(int[,] matriz)
        {
            int menor = matriz[0,0];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (matriz[i, j] < menor)
                        menor = matriz[i, j];
                }
            }
            Console.WriteLine($"O menor numero da matriz é: {menor}" +
                $"\n_________________________________________");
            return menor;
        }

        public static int[] MostrarMaiores(int[,] matriz, int[] maiores)
        {
            int maior;
            
            for (int i = 0; i < 10; i++)
            {
                int j = 0;
                maior = matriz[i, j];
                for (j = 0; j < 10; j++)
                {
                    if (matriz[i, j] > maior)
                        maior = matriz[i, j];
                }
                maiores[i] = maior;
            }
            int v = 1;
            Console.WriteLine("Maiores numeros por linha:");
            foreach(int numero in maiores)
            {
                Console.WriteLine($"linha {v} = {numero}" +
                    $"\n_________________________________________");
                v++;
            }
            return maiores;
        }
    }
}
