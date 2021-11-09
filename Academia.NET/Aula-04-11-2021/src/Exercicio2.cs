using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_11_2021.src
{
    class Exercicio2
    {

        //       2. Escreva um programa que leia um vetor com 10 elementos inteiros e escreva funções para fazer o que se pede(utilizar o vetor declarado globalmente)
        //a.Exibir os elementos do vetor na ordem inversa
        //b.Decompor em dois outros vetores, um contendo os elementos de índice ímpar e outro com os elementos de índice par
        //c.Decompor em dois outros vetores, um contendo os elementos de valor ímpar e outro com os elementos de valor par.

        public static void Executar()
        {
            Random rdm = new();
            int[] vetor = new int[10];
            int[] vetorPar = new int[5];
            int[] vetorImpar = new int[5];
            int opcao = 0;
            for (int i = 0; i < 10; i++)
            {
                vetor[i] = rdm.Next(1,20);
                
            }

            for(int i = 0; i<10; i++)
            {
                Console.WriteLine($"Valor {vetor[i]} no indice {i}");
            }


            Console.WriteLine("Digite a opção desejada:\n" +
                "1. Exibir os elementos do vetor na ordem inversa;\n" +
                "2. Decompor em 2 vetores, um contendo os elementos de índice ímpar e outro com os elementos de índice par;\n" +
                "3. Decompor em dois outros vetores, um contendo os elementos de valor ímpar e outro com os elementos de valor par.");
            try
            {
                opcao = int.Parse(Console.ReadLine());
            }
            catch (Exception E)
            {
                Console.WriteLine(E + " Você digitou um valor inválido. Tente novamente.");

            }

            switch (opcao)
            {
                case 1:
                    ExibirVetores.Inversa(vetor);
                    break;
                case 2:
                    vetorPar = ExibirVetores.DecomporIndice(vetor, 2);
                    int iPar = 0;
                    Console.WriteLine("_____________________\n" +
                        "Vetor Par");
                    foreach (int vPar in vetorPar)
                    {
                        Console.WriteLine($" valor vetor par = {vPar} valor original {vetor[iPar]} no indice {iPar} ");
                        iPar += 2;
                    }
                    vetorImpar = ExibirVetores.DecomporIndice(vetor, 1);
                    int iImpar = 1;
                    Console.WriteLine("_______________________\n" +
                        "Vetor Impar:");
                    foreach (int vImpar in vetorImpar)
                    {
                        Console.WriteLine($" valor no vetor par = {vImpar} valor original {vetor[iImpar]} no indice= {iImpar} ");
                        iImpar += 2;
                    }
                    break;
                case 3:
                    ExibirVetores.DecomporValor(vetor);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }

    }
}
