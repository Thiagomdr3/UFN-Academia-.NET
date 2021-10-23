using System;

namespace DivisiveisPorx
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Digite o valor de x");
            x = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 100; i++)
            {
                if(i % x == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
