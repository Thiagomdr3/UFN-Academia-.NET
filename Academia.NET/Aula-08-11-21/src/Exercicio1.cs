using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_08_11_21.src
{
    class Exercicio1
    {
        //1 . Escrever um programa que lê um vetor double de 15 elementos.A seguir, deve mostrar cada elemento do vetor multiplicado pelo seu índice(posição), em uma função chamada cálculo.

        public static void Iniciar()
        {
            Console.Clear();
            double[] vetor;
            double[] vetorMultiplicado;
            int posicoes = 0;
            bool ficar = true;

            while (ficar)
            {
                Console.WriteLine("Quantas posições terá o vetor?");

                try
                {
                    posicoes = int.Parse(Console.ReadLine());
                    ficar = false;
                }
                catch
                {
                    Console.WriteLine(" Você digitou um valor inválido. Tente novamente");
                }
            }
            vetor = new double[posicoes];

            vetor = Construir(vetor, posicoes, ficar);
            vetorMultiplicado = Calcular(vetor);

            Mostrar(vetor,vetorMultiplicado);
        }




        public static double[] Construir(double[] vetor, int posicoes, bool ficar)
        {
            for (int i = 0; i < posicoes; i++)
            {
                Console.WriteLine($"Digite um valor para a posíção {i + 1} do vetor");
                ficar = true;
                while (ficar)
                {

                    try
                    {
                        vetor[i] = double.Parse(Console.ReadLine());
                        ficar = false;
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine(" Você digitou um valor inválido. Tente novamente");
                        Console.WriteLine($"Digite um valor para a posíção {i + 1} do vetor");
                    }
                }

            }
            return vetor;
        }

        public static double[] Calcular(double[] vetor)
        {
            double[] vetorMultiplicado = new double[vetor.Length];

            for(int i = 0; i< vetor.Length; i++)
            {
                vetorMultiplicado[i] = vetor[i] * i;
            }

            return vetorMultiplicado;
        }

        public static void Mostrar(double[] vetor, double[] vetorMultiplicado)
        {
            int i = 0;

            Console.WriteLine("____________________________________________________________" +
                "\nVetor original:");
            foreach (double valor in vetor)
            {
                Console.Write($"{valor} | ");
            }

            Console.WriteLine("\n__________________________________________________________" +
                "\nVetor multiplicado pelo indice:");
            foreach (double valor in vetorMultiplicado)
            {
                Console.Write($"{valor} | ");
            }

            Console.WriteLine("\n__________________________________________________________" +
                "\nDemonstração do calculo:");
            foreach (double valor in vetorMultiplicado)
            {
                Console.WriteLine($"{vetor[i]} x {i} = {valor}");
                i++;
            }
        }
    }
}
