using System;
using Aula_04_11_2021.src;

namespace Aula_04_11_2021
{
    class Program
    {
        //1. Faça um programa que faça a leitura de dois números.Crie e chame as 4 funções para as operações matemáticas (soma, subtração, multiplicação e divisão).


//       2. Escreva um programa que leia um vetor com 30 elementos inteiros e escreva funções para fazer o que se pede(utilizar o vetor declarado globalmente)
//a.Exibir os elementos do vetor na ordem inversa
//b.Decompor em dois outros vetores, um contendo os elementos de índice ímpar e outro com os elementos de índice par
//c.Decompor em dois outros vetores, um contendo os elementos de valor ímpar e outro com os elementos de valor par.
        static void Main(string[] args)
        {

            Console.WriteLine("Qual exercicio pretende fazer?\n" +
                "1. Operações basicas com funções (Exercício 1);\n" +
                "2. Manipulação de vetor.");

            int opcao = int.Parse(Console.ReadLine());
            
            switch (opcao)
            {
                case 1:
                    Exercicio1.Executar();
                    break;
                case 2:
                    Exercicio2.Executar();
                    break;
            }
        }
    }
}
