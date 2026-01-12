using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Pessoa
    {
        public Pessoa() {}
        
        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} {Sobrenome} e tenho {Idade} anos.");
        }
    }
}