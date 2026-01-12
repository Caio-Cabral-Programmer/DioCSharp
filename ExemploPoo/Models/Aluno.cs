using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Aluno : Pessoa
    {
        public Aluno() {}

        public Aluno (string nome, string sobrenome, int idade) : base(nome, sobrenome, idade)
        {
        }

        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} {Sobrenome} e tenho {Idade} anos. Minha nota é {Nota}.");
        }

    }


}