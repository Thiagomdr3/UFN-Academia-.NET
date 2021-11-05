using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Aula_04_11_2021
{
    class Exercicio1
    {
        public static void Executar()
        {
            int sair = 0;
            double resultado;
            double n1 = 0, n2 = 0;
            string contOuSair, opcao;

            while (sair == 0)
            {
                Console.Clear();
                opcao = "";
                Console.WriteLine("Digite o primeiro número:");
                try
                {
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual operação deseja realizar?\n" +
                    "+. soma;\n" +
                    "-. subtração;\n" +
                    "/. multiplicação;\n" +
                    "*. divisão;\n" +
                    @"ou digite ""q"" para sair");

                    opcao = Console.ReadLine();
                }
                catch (Exception E)
                {
                    Console.WriteLine(E + " Você digitou um valor numérico invalido, tente novamente");
                }
                
                switch (opcao)
                {
                    case "+":
                        Console.WriteLine("Digite o segundo número:");
                        try
                        {
                            n2 = int.Parse(Console.ReadLine());
                        }
                        catch (Exception E)
                        {
                            Console.WriteLine(E + " Você digitou um valor numérico invalido, tente novamente");
                        }
                        resultado = Operacoes.Somar(n1, n2);
                        Console.WriteLine(resultado);
                        Console.WriteLine("Deseja realizar outro calculo ou sair?\n" +
                            "c. continuar;\n" +
                            "q. sair.");
                        contOuSair = Console.ReadLine();
                        if (contOuSair.Equals("q"))
                        {
                            sair = 1;
                        }
                        else if (contOuSair.Equals("c"))
                        {
                            sair = 0;
                        }
                        else
                        {
                            Console.WriteLine("Opção invalida. Tente novamente em ...");
                            for (int i = 5; i >= 0; i--)
                            {
                                Thread.Sleep(1000);
                                Console.WriteLine(i);
                            }
                        }
                        break;
                    case "-":
                        Console.WriteLine("Digite o segundo número:");
                        try
                        {
                            n2 = int.Parse(Console.ReadLine());
                        }
                        catch (Exception E)
                        {
                            Console.WriteLine(E + " Você digitou um valor numérico invalido, tente novamente");
                        }
                        resultado = Operacoes.Subtrair(n1, n2);
                        Console.WriteLine(resultado);
                        Console.WriteLine("Deseja realizar outro calculo ou sair?\n" +
                            "c. continuar;\n" +
                            "q. sair.");
                        contOuSair = Console.ReadLine();
                        if (contOuSair.Equals("q"))
                        {
                            sair = 1;
                        }
                        else if (contOuSair.Equals("c"))
                        {
                            sair = 0;
                        }
                        else
                        {
                            Console.WriteLine("Opção invalida. Tente novamente em ...");
                            for (int i = 5; i >= 0; i--)
                            {
                                Thread.Sleep(1000);
                                Console.WriteLine(i);
                            }
                        }
                        break;
                    case "*":
                        Console.WriteLine("Digite o segundo número:");
                        try
                        {
                            n2 = int.Parse(Console.ReadLine());
                        }
                        catch (Exception E)
                        {
                            Console.WriteLine(E + " Você digitou um valor numérico invalido, tente novamente");
                        }
                        resultado = Operacoes.Multiplicar(n1, n2);
                        Console.WriteLine(resultado);
                        Console.WriteLine("Deseja realizar outro calculo ou sair?\n" +
                            "c. continuar;\n" +
                            "q. sair.");
                        contOuSair = Console.ReadLine();
                        if (contOuSair.Equals("q"))
                        {
                            sair = 1;
                        }
                        else if (contOuSair.Equals("c"))
                        {
                            sair = 0;
                        }
                        else
                        {
                            Console.WriteLine("Opção invalida. Tente novamente em ...");
                            for (int i = 5; i >= 0; i--)
                            {
                                Thread.Sleep(1000);
                                Console.WriteLine(i);
                            }
                        }
                        break;
                    case "/":
                        Console.WriteLine("Digite o segundo número:");
                        try
                        {
                            n2 = int.Parse(Console.ReadLine());
                        }
                        catch (Exception E)
                        {
                            Console.WriteLine(E + " Você digitou um valor numérico invalido, tente novamente");
                        }
                        if (n2 == 0)
                        {
                            Console.WriteLine($"Opção invalida. {n1} não pode ser dividido por 0\nTente novamente em ...");
                            for (int i = 5; i >= 0; i--)
                            {
                                Thread.Sleep(1000);
                                Console.WriteLine(i);
                            }
                        }
                        else
                        {
                            resultado = Operacoes.Dividir(n1, n2);
                            Console.WriteLine(resultado);
                            Console.WriteLine("Deseja realizar outro calculo ou sair?\n" +
                                "c. continuar;\n" +
                                "q. sair.");
                            contOuSair = Console.ReadLine();
                            if (contOuSair.Equals("q"))
                            {
                                sair = 1;
                            }
                            else if (contOuSair.Equals("c"))
                            {
                                sair = 0;
                            }
                            else
                            {
                                Console.WriteLine("Opção invalida. Tente novamente em ...");
                                for (int i = 5; i >= 0; i--)
                                {
                                    Thread.Sleep(1000);
                                    Console.WriteLine(i);
                                }
                            }
                        }
                        break;
                    case "q":
                        sair = 1;
                        break;
                    default:
                        Console.WriteLine("Opção invalida. Tente novamente em ...");
                        for (int i = 5; i >= 0; i--)
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine(i);
                        }
                        break;
                }
            }
        }
    }
}
