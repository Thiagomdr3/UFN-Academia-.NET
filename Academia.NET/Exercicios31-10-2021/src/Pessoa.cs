using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios31_10_2021.src
{
    class Pessoa
    {
        //private int idade;
        //private string nome;
        //private string email;
        //private int telefone;


        public string _nome { get; private set; }
        private string _nome1;
        public static Pessoa Get()
        {
            Pessoa pe = new Pessoa();

            return pe;
        }



        /*public Pessoa(int idade, string nome, string email, int telefone)
{

public int idad { get { return this.idade} set { this.idade =idade} }

idade = this.idade;

}*/

    }
}
