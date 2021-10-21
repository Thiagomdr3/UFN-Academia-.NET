using System;

namespace ClienteVip
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uma loja fornece 10% de desconto para funcionários e 5% de desconto para clientes vips. Faça um programa que calcule o valor total a ser pago por uma pessoa. O programa deverá ler o valor total da compra efetuada e um código que identifique se o comprador é um cliente comum (1), funcionário (2) ou vip (3)

            int i = 1;

            while(i == 1)
            {
                Console.WriteLine("Qual o valor da compra?");
                double compra = double.Parse(Console.ReadLine());

                Console.WriteLine("Qual o codigo do cliente? " +
                    "\n1 = comum;" +
                    "\n2 = Funcionário;" +
                    "\n3 = VIP ");

                int codigo = int.Parse(Console.ReadLine());

                switch (codigo)
                {
                    case 1:
                        Console.WriteLine("O valor da sua compra é: " + compra);
                        Console.WriteLine("Gostaria de registrar uma nova compra? (0 = não    __    1 = sim)");
                        i = int.Parse(Console.ReadLine());
                        break;

                    case 2:
                        compra -= compra * 0.1;
                        Console.WriteLine("O valor da sua compra é: " + compra);
                        Console.WriteLine("Gostaria de registrar uma nova compra? (0 = não    __    1 = sim)");
                        i = int.Parse(Console.ReadLine());
                        break;

                    case 3:
                        compra -= compra * 0.05;
                        Console.WriteLine("O valor da sua compra é: " + compra);
                        Console.WriteLine("Gostaria de registrar uma nova compra? (0 = não    __    1 = sim)");
                        i = int.Parse(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("Tipo de cliente não encontreado");
                        Console.WriteLine("Gostaria de tentar novamente? (0 = não    __    1 = sim)");
                        i = int.Parse(Console.ReadLine());
                        break;

                }
            }
            Console.WriteLine("Obrigado. Volte sempre !!");

        }
    }
}
