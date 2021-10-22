using System;

namespace UsandoTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crie um programa para fazer a leitura de um numero. Se o numero for impar, transforme este numero em par. Se for par, mantenha o mesmo numero

            char x;
            
            Console.WriteLine("Digite um numero inteiro");
            int i = int.Parse(Console.ReadLine());

            x = (i % 2 == 0) ? 'p' : 'i';

            i = (i % 2 == 0) ? i : i + 1;
            
            Console.WriteLine("Voce entrou com um numero {0} transformando em par, se necessário ficou: {1}", x,i);


        }
    }
}
