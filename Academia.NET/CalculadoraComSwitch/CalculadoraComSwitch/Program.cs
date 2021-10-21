using System;

namespace SelecaoMes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implemente na calculadora desenvolvida as seguintes funções: Se a operação digitada for “+”, será efetuada a soma; Se a operação digitada for “-”, será efetuada a subtração; Se a operação digitada for “x”, será efetuada a multiplicação Se a operação digitada for “/”, será efetuada a divisão;

            int i = 1;

            while (i == 1)
            {
                Console.WriteLine("Digite o valor do primeiro numero:");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor do segundo numero:");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o operador (+ , - , / ou x):");
                char operador = char.Parse(Console.ReadLine());

                switch (operador)
                {
                    case '+':
                        Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
                        Console.WriteLine("Deseja realizar uma nova operação? (0 = não   _   1 = sim)");
                        i = int.Parse(Console.ReadLine());

                        break;

                    case '-':
                        Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
                        Console.WriteLine("Deseja realizar uma nova operação? (0 = não   _   1 = sim)");
                        i = int.Parse(Console.ReadLine());
                        break;

                    case '/':
                        Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
                        Console.WriteLine("Deseja realizar uma nova operação? (0 = não   _   1 = sim)");
                        i = int.Parse(Console.ReadLine());
                        break;

                    case 'x':
                        Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
                        Console.WriteLine("Deseja realizar uma nova operação? (0 = não   _   1 = sim)");
                        i = int.Parse(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("Você digitou um operador inválido.");
                        Console.WriteLine("Deseja tentar novamente? (0 = não   _   1 = sim)");
                        i = int.Parse(Console.ReadLine());
                        break;
                }

            }
        }

    }
}
