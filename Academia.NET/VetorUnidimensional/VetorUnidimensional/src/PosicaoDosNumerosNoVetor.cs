using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorUnidimensional.src
{
    class PosicaoDosNumerosNoVetor
    {
        /*Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após escreva a posição de cada número menor que zero desse vetor. Exemplo:
a. lê: |5.1|0|-3.6|4.1|-2.5|-1.3|-4|1.39|-128|-6.9|8.2|9|154|-88|6.4|7.1|...|
b. escreve: |3|5|6|7|9|10|14|*/

        public static void Iniciar()
        {
            int[] numeros = new int[30];

            for(int i = 0; i<30; i++)
            {
                Console.WriteLine("Digite um numero real para o indice "+(i+1));
                numeros[i] = int.Parse(Console.ReadLine());
            }
            int indice = 0;
            foreach(int index in numeros)
            {
                if (index < 0)
                {
                    Console.WriteLine(indice+1);
                }
                indice++;
            }
        }
    }
}
