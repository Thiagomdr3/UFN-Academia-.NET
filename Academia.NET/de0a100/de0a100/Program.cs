using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {

            //Escreva um algoritmo leia pelo teclado um valor inteiro chamado x, e então mostre na tela todos os números de 0 a 100, pulando de x em x.
            executar();

        }

        public static void executar()
        {
            int condicao = 1;



            while (condicao == 1)
            {

                Console.WriteLine("Digite um valor de incremento:");
                int incremento = int.Parse(Console.ReadLine());

                if (incremento >= 100 || incremento < 0)
                {
                    Console.WriteLine("Digite um valor positivo e menor que 100");
                    Console.WriteLine("Gostaria de tentar novamente? (0   =   nao      ____     1    =    sim)");
                    condicao = int.Parse(Console.ReadLine());
                }
                else
                {
                    for (int i = 0; i <= 100; i += incremento)
                    {
                        Console.WriteLine("i vale " + i);
                    }
                    Console.WriteLine("Gostaria de tentar novamente? (0   =   nao      ____     1    =    sim)");
                    condicao = int.Parse(Console.ReadLine());

                }
            }
        }
    }
}