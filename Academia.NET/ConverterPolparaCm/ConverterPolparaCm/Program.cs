using System;

namespace ConverterPolparaCm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Imprima uma tabela de conversão de polegadas para centímetros, de 1 a 20.Considere que Polegada = Centímetro * 2,54

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("{0}cm = {1}Pol", i, i + 2.54);
            }
        }
    }
}
