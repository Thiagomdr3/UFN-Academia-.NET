using System;

namespace DesafioPrimeiraSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 1000;

            for (int i = 2, u = 997; i <= 50; i++, u = u - 3)
            {
                if (i % 2 == 0)
                {
                    result -= u/i ;
                }
                else
                {
                    result += u / i;
                }
            }

            Console.WriteLine(result);
        }
    }
}
