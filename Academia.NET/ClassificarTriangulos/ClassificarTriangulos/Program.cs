using System;

namespace ClassificarTriangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] triangulo = new double[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite a medida {0} do triangulo", i);
                triangulo[i] = double.Parse(Console.ReadLine());
            }

            if (triangulo[0] + triangulo[1] > triangulo[2] && triangulo[1] + triangulo[2] > triangulo[0] && triangulo[0] + triangulo[2] > triangulo[1])
            {
                Console.WriteLine("é triangulo!!");
                if (triangulo[0] == triangulo[1] && triangulo[1] == triangulo[2])
                {
                    Console.WriteLine("O triangulo é equilatero");
                }
                else if (triangulo[0] == triangulo[1] || triangulo[0] == triangulo[2] || triangulo[1] == triangulo[2])
                {
                    Console.WriteLine("O triangulo é isóceles");
                }
                else
                {
                    Console.WriteLine("O triangulo é escaleno");
                }
            }
            else
            {
                Console.WriteLine("Não é triangulo!");
            }
        }
    }
}
