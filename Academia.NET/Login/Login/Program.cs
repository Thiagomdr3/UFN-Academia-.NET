using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se o usuário errou, diga se o numero que ele digitou é maior ou menor que o valor armazenado!

            string login = "Thiago", login1;
            int senha = 1234, senha1;

            Console.WriteLine("Digite seu login:");
            login1 = Console.ReadLine();

            Console.WriteLine("Digite a senha:");
            senha1 = int.Parse(Console.ReadLine());

            
        }
    }
}
