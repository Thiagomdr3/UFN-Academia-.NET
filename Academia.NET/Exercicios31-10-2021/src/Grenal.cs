using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios31_10_2021.src
{
    class Grenal
    {
        /*A Federação Gaúcha de Futebol contratou um estudante de Ciência da Computação para fazer um levantamento estatístico do resultado de vários Grenais. Escreva um algoritmo que leia para cada Grenal, o número de gols marcados pelo Grêmio e o número de gols marcados pelo Internacional, imprimindo o nome do time vitorioso ou a palavra EMPATE. Após, ele deve escrever a mensagem:
Novo Grenal (1. Sim 2. Não)?
e solicitar uma resposta. Se a resposta for 1, o algoritmo deve solicitar novamente o número de gols marcados pelos times em uma nova partida; se a resposta for 2, ele deve ser encerrado imprimindo:
• quantos Grenais fizeram parte da estatística;
• o número de vitórias do Grêmio;
• o número de vitórias do Internacional;
• o número de empates; e
• uma mensagem indicando qual o time que venceu o maior número de Grenais (ou “Não houve vencedor”).
*/

        public static void Iniciar()
        {
            string[][] grenais;

            int qntddGrenais;
            

            qntddGrenais = GrenalMensagems.Iniciar();

            grenais = new string[2][];

            grenais = GrenalEdicao.Definir(grenais, qntddGrenais);

            grenais = GrenalEdicao.Preencher(grenais);
        }
    }
}
