using System;

namespace TabuadadeUmNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            Console.WriteLine("Digite um numero");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                result = num * i;
                Console.WriteLine("{0} x {1} = {2}", num, i, result);
            }
        }
    }
}
