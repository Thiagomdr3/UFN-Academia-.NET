using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_11_2021
{
    class Operacoes
    {
        public static double Somar(double n1, double n2)
        {
            double resultado = n1 + n2;
            return resultado;
        }

        public static double Subtrair(double n1, double n2)
        {
            double resultado = n1 - n2;
            return resultado;
        }

        public static double Multiplicar(double n1, double n2)
        { 
            double resultado = n1 * n2;
            return resultado;
        }

        public static double Dividir(double n1, double n2)
        {
            double resultado = n1 / n2;
            return resultado;
        }
    }
}
