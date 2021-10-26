using System;

namespace SequenciaFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Os dois primeiros números da sequência de Fibonacci são 0 e 1. Qualquer outro número desta sequência pode ser calculado pela soma dos dois imediatamente anteriores: F0=0 ; F1=1 ; Fn=Fn−1+Fn−2
               Os primeiros números de Fibonacci são: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …
               Fazer um algoritmo que leia um número N e mostre os primeiros N números da série de Fibonacci.*/

            Console.WriteLine("Digite um numero para calcularmos a sequencia fibonacci:");
            int n = int.Parse(Console.ReadLine());
            int z, y=1, x = 0;
            for (int i = 0; i <= n; i++)
            {
                if(i == 0 || i == 1)
                {
                    Console.Write("{0}, ", i);
                    
                }
                else
                {
                    z = x + y;
                    x = y;
                    y = z;
                    Console.Write("{0}, ", z);
                    


                }
            }
        }
    }
}
