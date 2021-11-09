using System;
using System.Threading;
using Aula_08_11_21.src;

namespace Aula_08_11_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 . Escrever um programa que lê um vetor double de 15 elementos.A seguir, deve mostrar cada elemento do vetor multiplicado pelo seu índice(posição), em uma função chamada cálculo.


            //2 . Escreva um programa que leia uma matriz de inteiros com ordem 10x10 e por meio de funções faça o que se pede:

            //a.Exiba o menor elemento da matriz
            //b.Encontre e exiba o maior elemento de cada uma das linhas da matriz

            int opcao = 0;
            bool ficar1 = true, ficar2 = true;


            while (ficar2)
            {
                while (ficar1)
                {
                    Console.WriteLine("Selecione o Exercicio que queira visualizar:" +
                    "\n1. Exercício 1;" +
                    "\n2. Exercício 2.");
                    try
                    {
                        opcao = int.Parse(Console.ReadLine());
                        ficar1 = false;
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Você digitou um valor inválido. Tente novamente...");
                    }

                    if (opcao == 1 || opcao == 2)
                    {
                        ficar1 = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Você digitou um valor inválido. Tente novamente...");
                        ficar1 = true;
                    }
                }
                if (opcao == 1)
                {
                    Exercicio1.Iniciar();
                }
                else
                {
                    Exercicio2.Iniciar();
                }
                
                while (true)
                {
                    string continuar = "";
                    Console.WriteLine("Deseja realijar um novo exercicio? S/N");
                    try
                    {
                       continuar = Console.ReadLine();
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Você digitou um valor inválido. Tente novamente...");
                    }

                    if(continuar == "s" || continuar == "S")
                    {
                        Console.Clear();
                        ficar1 = true;
                        break;

                    }else if(continuar == "n" || continuar == "N")
                    {
                        Console.WriteLine("Você optou por sair. O programa será fechado em...");
                        for(int i = 5; i>=0; i--)
                        {
                            Console.WriteLine(i);
                            Thread.Sleep(1000);
                        }
                        ficar2 = false;
                        break;
                        
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Você digitou um valor inválido. Tente novamente...");
                    }
                }
            }
        }
    }
}
