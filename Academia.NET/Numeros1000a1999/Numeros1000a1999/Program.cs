using System;

namespace Numeros1000a1999
{
    class Program
    {
        static void Main(string[] args)
        {
            //gerar numeros de 1000 a 1999 que divididos por 11 dao resto = 5
            for (int i = 1000; i <= 1999; i++)
            {
                if (i % 11 == 5)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
