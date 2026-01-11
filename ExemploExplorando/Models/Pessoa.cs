using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {

        // Construtor padrão (sem parâmetros) → serve para criar objetos sem precisar passar valores na criação, precisamos declará-lo explicitamente
        public Pessoa() { }

        // Construtor → ele tem o mesmo nome da classe e não tem tipo de retorno
        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }

        private string _nome;
        private int _idade;
        public string Nome
        {

            // Modo simplificado, conhecido como expression body
            get => _nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos.");
        }
    }
}

// =======================================================
// Modo verboso, mas as vezes é necessário utilizá-lo para validações
// get
// {
//     return _nome.ToUpper();
// }