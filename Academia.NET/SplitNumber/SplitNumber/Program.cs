using System;

namespace SplitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Existem números de 4 dígitos (entre 1000 e 9999) que obedecem à seguinte característica: se dividirmos o número em dois números de dois dígitos, um composto pela dezena e pela unidade, e outro pelo milhar e pela centena, somarmos estes dois novos números gerando um terceiro, o quadrado deste terceiro número é exatamente o número original de quatro dígitos. Por exemplo: 2025 dividindo: 20 e 25 e somando temos 45 e 45² = 2025.
               Escreva um programa para calcular todos os números que obedecem a esta característica.
                DICA IMPORTANTE: LEMBREM - SE DA MINHA EXPLICAÇÃO SOBRE RESTO DA DIVISÃO!
                resto da divisão de um número por 5 = n % 5 - irá variar de 0 até 4.
                resto da divisão de um número por 4 = n % 4 - irá variar de 0 até 3.
                resto da divisão de um número por 3 = n % 3 - irá variar de 0 até 2.
                resto da divisão de um número por 2 = n % 2 - irá variar entre 0 e 1.*/

            int mc, du, soma;

            for (int i = 1000; i <= 9999; i++)
            {
                mc = i / 100;
                du = i % 100;

                soma = mc + du;

                soma *= soma;

                if (soma == i)
                {
                    Console.WriteLine(soma);
                }
            }
        }
    }
}
