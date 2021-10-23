using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //calcular fatorial de um numero
            Console.WriteLine("Digite um numero para calcular um fatorial.");
            int num = int.Parse(Console.ReadLine());

            int fatorial = 1;

            for (int i = num; i > 0; i--)
            {
                fatorial = i * fatorial;
            }

            Console.WriteLine(fatorial);
        }
    }
}
