using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios31_10_2021.src
{
    class GrenalEdicao
    {

        public static string[][] Preencher(string[][] grenais)
        {
            int sair, compare, resposta = 1;


            for (int j = 1; j < grenais[0].Length; j++)
            {
                for (int i = 0; i < 2; i++)
                {

                    if (i == 0)
                    {
                        sair = 1;
                        while (sair == 1)
                        {
                            Console.WriteLine("Quantos gols o {0} marcou no {1}º jogo?", grenais[0][0], j);
                            grenais[i][j] = Console.ReadLine();

                            try
                            {
                                compare = int.Parse(grenais[i][j]);
                                sair = 0;
                            }
                            catch
                            {
                                Console.WriteLine("Você digitou um opção inválida. Tente novamente.");
                            }
                        }


                    }
                    else
                    {
                        sair = 1;
                        while (sair == 1)
                        {
                            Console.WriteLine("Quantos gols o {0} marcou no {1}º jogo?", grenais[1][0], j);
                            grenais[i][j] = Console.ReadLine();

                            try
                            {
                                compare = int.Parse(grenais[i][j]);
                                sair = 0;
                            }
                            catch
                            {
                                Console.WriteLine("Você digitou um opção inválida. Tente novamente.");
                            }
                        }

                    }
                }
            }

            while (resposta == 1)
            {
                
                resposta = GrenalMensagems.Mostrar(grenais);

                if (resposta == 1)
                {
                   grenais= Adicionar(grenais);
                }
            }



            return grenais;

        }
        public static string[][] Adicionar(string[][] grenais)
        {
            Array.Resize(ref grenais[0], grenais[0].Length + 1);
            Array.Resize(ref grenais[1], grenais[1].Length + 1);

            int sair, compare;


            for (int j = grenais[0].Length -1; j < grenais[0].Length; j++)
            {
                for (int i = 0; i < 2; i++)
                {

                    if (i == 0)
                    {
                        sair = 1;
                        while (sair == 1)
                        {
                            Console.WriteLine("Quantos gols o {0} marcou no {1}º jogo?", grenais[0][0], j);
                            grenais[i][j] = Console.ReadLine();

                            try
                            {
                                compare = int.Parse(grenais[i][j]);
                                sair = 0;
                            }
                            catch
                            {
                                Console.WriteLine("Você digitou um opção inválida. Tente novamente.");
                            }
                        }


                    }
                    else
                    {
                        sair = 1;
                        while (sair == 1)
                        {
                            Console.WriteLine("Quantos gols o {0} marcou no {1}º jogo?", grenais[1][0], j);
                            grenais[i][j] = Console.ReadLine();

                            try
                            {
                                compare = int.Parse(grenais[i][j]);
                                sair = 0;
                            }
                            catch
                            {
                                Console.WriteLine("Você digitou um opção inválida. Tente novamente.");
                            }
                        }

                    }
                }
            }
            return grenais;


        }
        public static string[][] Definir(string[][] grenais, int qntddGrenais)
        {
            grenais[0] = new string[qntddGrenais + 1];
            grenais[1] = new string[qntddGrenais + 1];
            grenais[0][0] = "Gremio";
            grenais[1][0] = "Internacional";

            return grenais;
        }
    }
}
