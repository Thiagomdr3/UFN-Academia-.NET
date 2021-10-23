using System;

namespace ContadorPesrsonalizado
{
    class Program
    {
        static void Main(string[] args)
        {
            // usuario digita valor inicial e final e se ele deseja pular os valores pares ou impares e mostre os valores


            Console.WriteLine("Digite o valor inicial");
            int inicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor final");
            int final = int.Parse(Console.ReadLine());

            Console.WriteLine("Gostaria de pular os valores pares ou impares? \n1. Impar\n2. Par)");

            int escolha = int.Parse(Console.ReadLine());

            for (int i = inicio; i <= final; i++)
            {
                if (escolha == 2)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }

                }
                else if(i % 2 == 1)
                {
                    Console.WriteLine(i);
                }

            }

        }
    }
}
