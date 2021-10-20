using System;

namespace MediaNotas
{
    
    class Program
    {

        static void Main(string[] args)
        {

            Calcular();
        }

        public static void Calcular()
        {
            int op = 1;
            while (op == 1)
            {
                double notas = 0;
                Console.WriteLine("Quatas notas gostaria  de calcular a média.");
                int numNotas = int.Parse(Console.ReadLine());

                for (int i = 0; i < numNotas; i++)
                {
                    Console.WriteLine("Digite a {0}ª nota", i);
                    notas += double.Parse(Console.ReadLine());
                }

                Console.WriteLine("A media de notas desse aluno é {0}", notas);

                Console.WriteLine("Gostaria de calcular a média de mais notas? (1 = yes --- 0 = NO)");
                op = int.Parse(Console.ReadLine());

            }


        }
    }
}
