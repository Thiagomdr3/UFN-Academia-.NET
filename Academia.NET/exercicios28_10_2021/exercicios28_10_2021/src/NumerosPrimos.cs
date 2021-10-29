using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace exercicios28_10_2021.src
{
    class NumerosPrimos
    {
        public static void Iniciar()
        {
            int numero = 0, laco=0;

            while(laco == 0)
            {
                Console.Clear();
                Console.WriteLine("Digite um número para identificarmos se é primo ou não:");
                
                try
                {
                    numero = int.Parse(Console.ReadLine());
                    laco = 1;
                }
                catch
                {
                    Console.WriteLine("Você digitou um valor inválido. Tente novamente em...");
                    for (int i = 5; i > 0; i--)
                    {
                        Console.WriteLine(i);
                        Thread.Sleep(1000);
                    }
                }

                if(numero == 0)
                {
                    Console.WriteLine("Você digitou um valor inválido. Tente novamente em...");
                    for (int i = 5; i > 0; i--)
                    {
                        Console.WriteLine(i);
                        Thread.Sleep(1000);
                    }
                }
            }
           
            string resposta = Calcular(numero);
            Console.WriteLine(resposta);

        }

        public static string Calcular(int numero)
        {
            string resposta = "";
            int contador = 0;
            if (numero == 1)
            {
                resposta = numero + " não é primo";
            }
            else
            {
                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        contador++;
                    }
                }
            }
            if (contador == 2)
            {
                resposta = numero + " é primo";
            }
            else
            {
                resposta = numero + " não é primo";
            }

            return resposta;
        }
    }
}
