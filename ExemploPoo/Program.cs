using ExemploPoo.Interfaces;
using ExemploPoo.Models;

// ============================================================
// OOP
Console.WriteLine();
Console.WriteLine("=== OOP ===");
Console.WriteLine();

// Abstração
Console.WriteLine();
Console.WriteLine("- Abstração");
Console.WriteLine();

Pessoa pessoa1 = new Pessoa("Caio", "Cabral", 25);
pessoa1.Apresentar();

// Encapsulamento
Console.WriteLine();
Console.WriteLine("- Encapsulamento");
Console.WriteLine();

ContaCorrente conta1 = new ContaCorrente(123456, 1000);
conta1.Sacar(100);
conta1.ExibirSaldo();

// Herança
Console.WriteLine();
Console.WriteLine("- Herança");
Console.WriteLine();

Aluno aluno1 = new Aluno();
aluno1.Nome = "Maria";
aluno1.Sobrenome = "Silva";
aluno1.Idade = 20;
aluno1.Email = "maria.silva@email.com";
aluno1.Nota = 8.5;
aluno1.Apresentar();

// Polimorfismo (Override/Late Binding) - Em tempo de execução
Console.WriteLine();
Console.WriteLine("- Polimorfismo (Override/Late Binding) - Em tempo de execução");
Console.WriteLine();

Professor professor1 = new Professor();
professor1.Nome = "João";
professor1.Sobrenome = "Pereira";
professor1.Idade = 40;
professor1.Email = "joao.pereira@email.com";
professor1.Salario = 3500.00m;
professor1.Apresentar();

Aluno aluno2 = new Aluno();
aluno2.Nome = "Ana";
aluno2.Sobrenome = "Oliveira";
aluno2.Idade = 22;
aluno2.Email = "ana.oliveira@email.com";
aluno2.Nota = 9.0;
aluno2.Apresentar();

// Polimorfismo (Overload/Early Binding) - Em tempo de compilação
Console.WriteLine();
Console.WriteLine("- Polimorfismo (Overload/Early Binding) - Em tempo de compilação");
Console.WriteLine();

Console.WriteLine("Calculadora utilizando com 2 parâmetros e 3 parâmetros:");
Calculadora calculadora = new Calculadora();
Console.WriteLine($"Soma: {calculadora.Somar(10, 20)}"); // Método de instância
Console.WriteLine($"Soma: {Calculadora.Somar(10, 20, 30)}"); // Método estático
 

// Classe Abstrata e Método Abstrato
Console.WriteLine();
Console.WriteLine("- Classe Abstrata e Método Abstrato");
Console.WriteLine();

Corrente contaCorrente = new Corrente();
contaCorrente.Creditar(500);
contaCorrente.ExibirSaldo();

// Classe Object - É a superclasse de todas as classes em C#
Console.WriteLine();
Console.WriteLine("- Classe Object - É a superclasse de todas as classes em C#");
Console.WriteLine();

Computador computador = new Computador();
Console.WriteLine(computador.ToString());

// Interface
Console.WriteLine();
Console.WriteLine("- Interface");
Console.WriteLine();

ICalculadora calc = new Calculadora(); // Aqui podemos usar a interface como tipo, mas não podemos instanciá-la diretamente
int resultadoSoma = calc.Somar(15, 25);
int resultadoSubtracao = calc.Subtrair(30, 10);
Console.WriteLine($"Resultado da soma: {resultadoSoma}");
Console.WriteLine($"Resultado da subtração: {resultadoSubtracao}");