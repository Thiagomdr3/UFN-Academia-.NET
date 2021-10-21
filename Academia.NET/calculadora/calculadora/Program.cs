using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia 2 números do usuário, após isso, mostre esta mensagem ao usuário:“Informe 1 para soma, 2 para subtração, 3 para multiplicação e 4 para divisão”Leia a escolha do usuário e faça o que ele pediu!

            Calcular();
            

        }

        public static void Calcular()
        {
            int i = 1;

            while (i == 1)
            {
                double result = 0;

                Console.WriteLine("Digite o primeiro numero:");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo numero:");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("informe a operação que deseja realizar:" +
                    "\n1. soma" +
                    "\n2. subtração" +
                    "\n3. multiplicação" +
                    "\n4. divisão");

                int opc = int.Parse(Console.ReadLine());

                if (opc == 1)
                {
                    result = num1 + num2;
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
                    Console.WriteLine("Deseja realizar outra operação?" +
                    "\n1. sim" +
                    "\n0. não");
                    i = int.Parse(Console.ReadLine());
                }
                else if (opc == 2)
                {
                    result = num1 - num2;
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, result);
                    Console.WriteLine("Deseja realizar outra operação?" +
                    "\n1. sim" +
                    "\n0. não");
                    i = int.Parse(Console.ReadLine());
                }
                else if (opc == 3)
                {
                    result = num1 * num2;
                    Console.WriteLine("{0} x {1} = {2}", num1, num2, result);
                    Console.WriteLine("Deseja realizar outra operação?" +
                    "\n1. sim" +
                    "\n0. não");
                    i = int.Parse(Console.ReadLine());
                }
                else if (opc == 4)
                {
                    result = num1 / num2;
                    Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
                    Console.WriteLine("Deseja realizar outra operação?" +
                    "\n1. sim" +
                    "\n0. não");
                    i = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Você digitou uma opção invalida!! Tente novamente");
                }
            }
        }
    }
}
