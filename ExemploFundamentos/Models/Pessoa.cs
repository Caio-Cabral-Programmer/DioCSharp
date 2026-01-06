namespace ExemploFundamentos.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
            // Quebra de linha → adicionar \n
            // Console.WriteLine($"Olá, meu nome é {Nome} \n e tenho {Idade} anos.");
        }

    }
    
}

// PascalCase para nomes de classes e métodos
// camelCase para nomes de variáveis e parâmetros
// Abreviações não são recomendadas (ex: qtd, num)
// Evitar usar "var" para declaração de variáveis, prefira o tipo explícito
// Caracteres especiais não são permitidos em nomes de variáveis (ex: acentuação, ç, espaço)
// Nomes de variáveis devem ser descritivos (ex: nomeCompleto ao invés de n)

