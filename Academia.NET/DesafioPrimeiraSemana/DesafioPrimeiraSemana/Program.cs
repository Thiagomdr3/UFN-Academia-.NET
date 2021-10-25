using System;

namespace DesafioPrimeiraSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeradorEditavel =1000, iEditavel=0, limiteEditavel = 50;
            double denominadorEditavel = 1;
            double[] numeros = new double[limiteEditavel];

            MostrarCalculo(iEditavel,numeradorEditavel,limiteEditavel, denominadorEditavel, numeros);

            Etapa2( limiteEditavel, numeros);



            static void MostrarCalculo(int iEditavel, int numeradorEditavel, int limiteEditavel, double denominadorEditavel, double[] numeros)
            {
                int i = iEditavel, numerador, limite = limiteEditavel;
                double denominador;
                for (numerador = numeradorEditavel, denominador = denominadorEditavel; denominador <= limite; numerador -= 3, denominador++)
                {
                    if (denominador % 2 != 0)
                    {
                        Console.Write("+({0}/{1} = {2})", numerador, denominador, Math.Round((numerador / denominador), 2));
                        numeros[Convert.ToInt32(denominador) - 1] = Math.Round((numerador / denominador), 2);
                    }
                    else
                    {
                        Console.Write("-({0}/{1} = {2})", numerador, denominador, Math.Round((numerador / denominador), 2));
                        numeros[Convert.ToInt32(denominador) - 1] = Math.Round((numerador / denominador), 2);
                    }
                }
                Console.Write(" = x ");
                Console.WriteLine("\n____________________________________________________________________________");

                
                foreach (double index in numeros)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("+(" + index + ")");
                    }
                    else
                    {
                        Console.Write("-(" + index + ")");
                    }
                    i++;
                }                             
            }

            static void Etapa2( int limite, double[] numeros)
            {
                int i = 0;
                double soma = 0;
                Console.Write(" = x ");
                Console.WriteLine("\n____________________________________________________________________________");

                for (int index = 0; index < limite; index++)
                {
                    Console.Write("+({0})", Math.Round(numeros[index] - numeros[index + 1], 2));
                    soma += Math.Round(numeros[index] - numeros[index + 1], 2);
                    numeros[i] = Math.Round(numeros[index] - numeros[index + 1], 2);
                    index++;
                    i++;
                }

                Console.Write(" = x ");
                Console.WriteLine("\n____________________________________________________________________________");
                Console.WriteLine("x = "+soma);
            }
        }
    }
}
