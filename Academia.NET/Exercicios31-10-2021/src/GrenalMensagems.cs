using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios31_10_2021.src
{
    class GrenalMensagems
    {
        public static int Iniciar()
        {
            int qntddGrenais = 0;
            int sair = 1;
            while (sair == 1)
            {
                
                Console.WriteLine("Bem vindo às estatisticas Grenais");
                Console.WriteLine("Digite quantos grenais entraram na estatisca:");

                try
                {
                    qntddGrenais = int.Parse(Console.ReadLine());
                    sair = 2;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Você digitou um opção inválida. Tente novamente.");
                }
            }
            
            return qntddGrenais;
        }

        public static int Continuar()
        {
            int resposta= 0;
            int sair = 1;
            while (sair == 1)
            {
                Console.WriteLine("Desenha acrescentar mais jogos a estatistica?\n" +
                "1. Sim\n" +
                "2. Não");
                try
                {
                    resposta = int.Parse(Console.ReadLine());
                    if (resposta == 1 || resposta == 2)
                    {
                        sair = 0;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Você digitou um opção inválida. Tente novamente.");
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Você digitou um opção inválida. Tente novamente.");
                }
            }
            return resposta;

        }

        public static int Mostrar(string[][] grenais)
        {
            int vitoriasGremio, vitoriasInter, empates;
            int golsGremio, golsInter;

            Console.Clear();
            vitoriasGremio = 0;
            vitoriasInter = 0;
            empates = 0;
            for (int j = 1; j < grenais[0].Length; j++)
            {
                golsGremio = int.Parse(grenais[0][j]);
                golsInter = int.Parse(grenais[1][j]);

                if (golsInter > golsGremio)
                {
                    Console.Write(" Rsultado do {0}º jogo: {1} {2} x {3} {4}\n", j, grenais[1][0], grenais[1][j], grenais[0][j], grenais[0][0]);
                    vitoriasInter++;
                }
                else if (golsInter < golsGremio)
                {
                    Console.Write(" Rsultado do {0}º jogo: {1} {2} x {3} {4}\n", j, grenais[0][0], grenais[0][j], grenais[1][j], grenais[1][0]);
                    vitoriasGremio++;
                }
                else
                {
                    Console.Write(" Rsultado do {0}º jogo: {1} {2} x {3} {4}\n", j, grenais[0][0], grenais[0][j], grenais[1][j], grenais[1][0]);
                    empates++;
                }

            }

            Console.WriteLine("{0} vitorias do Inter -- {1} vitorias do Gremio e {2} empates", vitoriasInter, vitoriasGremio, empates);
            if (vitoriasGremio > vitoriasInter)
            {
                Console.WriteLine("O Gremio tem mais vitorias que o inter: \n" +
                    "Gremio tem {0}\n" +
                    "Inter tem {1}\n" +
                    "Houveram {2} empates", vitoriasGremio, vitoriasInter, empates);
            }
            else if (vitoriasGremio < vitoriasInter)
            {
                Console.WriteLine("O Inter tem mais vitorias que o Gremio: \n" +
                    "Inter tem {1}\n" +
                    "Gremio tem {0}\n" +
                    "Houveram {2} empates", vitoriasGremio, vitoriasInter, empates);
            }
            else
            {
                Console.WriteLine("O Inter e Gremio empataram em vitorias: \n" +
                    "Inter tem {1}\n" +
                    "Gremio tem {0}\n" +
                    "Houveram {2} empates", vitoriasGremio, vitoriasInter, empates);
            }
            

            return Continuar();

        }
    }
}
