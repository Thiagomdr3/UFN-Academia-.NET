using System;

namespace CalculoAumentoSalarial
{
    class Program
    {
        static void Main(string[] args)
        {

            //O usuario informa o nome do funcionario, o salario do funcionario. O sistema calcula o aumento com base em: salario até 900 aumento de 5% maior que 900 até 1400 aumento de 8% salario superior a 1400 aumento de 10%

            Console.WriteLine("Qual o nome do funcionário?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual o salario do " + nome);
            double salario = double.Parse(Console.ReadLine());

            if(salario <= 900)
            {
                salario += salario * 0.05;
            }
            else if(salario > 900 && salario <= 1400)
            {
                salario += salario * 0.08;
            }
            else if(salario > 1400)
            {
                salario += salario * 0.1;
            }

            Console.WriteLine("O salario do {0} agora é {1}", nome, salario);
        }
    }
}
