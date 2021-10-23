using System;

namespace MediaFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            //ler a qndd de alunos em uma turma e entao, para cada aluno leia suas 3 notas do semestre e na tela sua média final e se está aprovado ou não.
    
            double medias, notas, sumNotas;

            Console.WriteLine("Quantos alunos temos nessa turma?");
            int numAlunos = int.Parse(Console.ReadLine());

            string[] alunos = new string [numAlunos];

            for(int u = 0; u < numAlunos; u++)
            {
                Console.WriteLine("Digite o nome do aluno " + (u + 1));
                alunos[u] = Console.ReadLine();
            }

            

            for (int i = 0; i < numAlunos; i++)
            {
                sumNotas = 0;
                for (int v = 0; v < 3; v++)
                {
                    Console.WriteLine("Digite a {0}ª nota do aluno {1}", (v+1), alunos[i]);
                    notas = double.Parse(Console.ReadLine());
                    sumNotas = sumNotas + notas;
                }
                medias = sumNotas / 3;
                Console.WriteLine("a média do aluno {0} é {1} ", alunos[i], medias);
                if (medias > 6)
                {
                    Console.WriteLine("o aluno {0} está aprovado ", alunos[i]);
                }
                else
                {
                    Console.WriteLine("o aluno {0} está reprovado ", alunos[i]);
                }
            }
        }
    }
}
