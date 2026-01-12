using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Professor : Pessoa
    {
        public Professor() {}
        public Professor(string nome, string sobrenome, int idade) : base(nome, sobrenome, idade)
        {
        }

        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} {Sobrenome}, tenho {Idade} anos e meu salário é {Salario:C}.");
        }
    }
}