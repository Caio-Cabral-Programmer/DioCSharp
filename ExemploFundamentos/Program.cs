using ExemploFundamentos.Models;


// ===================================================
// Instanciando um objeto da classe Pessoa:
Console.WriteLine("Instanciando um objeto da classe Pessoa:");

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Caio";
pessoa1.Idade = 26;
pessoa1.Apresentar();

// Existe esta forma mais enxuta de inicializar objetos em C#
// Pessoa pessoa1 = new Pessoa
// {
//     Nome = "Caio",
//     Idade = 26
// };


// ===================================================
// Tipos de dados comuns em C#:
Console.WriteLine();
Console.WriteLine("Tipos de dados comuns em C#:");


    string apresentacao = "Olá, seja bem-vindo."; // string

    int quantidade = 30; // inteiro

    double altura = 1.80; // ponto flutuante

    decimal preco = 1.80M; // ponto flutuante de alta precisão

    bool condicao = true; // booleano (true ou false)

    Console.WriteLine(apresentacao);
    Console.WriteLine("Quantidade: " + quantidade);
    Console.WriteLine("Altura: " + altura);
    Console.WriteLine("Altura: " + altura.ToString("0.00")); // formatar com 2 casas decimais
    Console.WriteLine("Preço: " + preco);
    Console.WriteLine("Condição: " + condicao);


// ===================================================
// Modificando valores das variáveis com o operador de atribuição
Console.WriteLine();
Console.WriteLine("Modificando valores das variáveis:");

    apresentacao = "Olá, meu nome é Caio.";
    quantidade = 100;

    Console.WriteLine(apresentacao);
    apresentacao = apresentacao + " Estou aprendendo C#.";
    Console.WriteLine(apresentacao);
    Console.WriteLine("Quantidade: " + quantidade);
    quantidade = quantidade + 50;
    Console.WriteLine("Quantidade Modificada: " + quantidade);
    quantidade += 50;
    Console.WriteLine("Quantidade Modificada com atribuição composta [+=] : " + quantidade);


// ===================================================
// DateTime
Console.WriteLine();
Console.WriteLine("Trabalhando com DateTime:");

    DateTime dataAtual = DateTime.Now;

    Console.WriteLine("Data e hora atual: " + dataAtual);
    Console.WriteLine("Data atual: " + dataAtual.ToString("dd/MM/yyyy"));
    Console.WriteLine("Hora atual: " + dataAtual.ToString("HH:mm"));


// ===================================================
// Constantes
// Constantes são variáveis cujo valor não pode ser alterado durante a execução do programa
Console.WriteLine();
Console.WriteLine("Trabalhando com constantes:");

    const double PI = 3.14;

    Console.WriteLine("Valor de PI: " + PI);


// ===================================================
// Conversão de tipos, chamado de Cast ou Type Casting em inglês
// Utiliza-se o método Convert para converter tipos de dados, Parse para converter strings e TryParse para tentar converter strings sem lançar exceção
// Convert, Parse e TryParse - Diferença → Convert lida com valores nulos, Parse não e TryParse tenta converter sem lançar exceção
// TryParse é mais seguro para conversão de strings, pois evita exceções em caso de falha e seu uso é recomendado quando a entrada pode ser incerta
 
Console.WriteLine();
Console.WriteLine("Trabalhando com conversão de tipos:");

    string valorString = "15";
    int valorInteiro = Convert.ToInt32(valorString);
    // int valorInteiro = int.Parse(valorString);
    // int valorInteiro;
    // int.TryParse(valorString, out valorInteiro); Explicação: tenta converter valorString para inteiro, se conseguir atribui a valorInteiro, se não atribui 0

    Console.WriteLine("Valor String: " + valorString);
    Console.WriteLine("Valor Inteiro: " + valorInteiro);


// ===================================================
// Conversão para string
// Utiliza-se o método ToString() para converter outros tipos de dados para string. É um método da classe Object, do qual todas as classes em C# herdam.
Console.WriteLine();
Console.WriteLine("Trabalhando com conversão para string:");

    int inteiro = 20;
    double pontoFlutuante = 45.89;
    bool booleano = true;

    string inteiroString = inteiro.ToString();
    string pontoFlutuanteString = pontoFlutuante.ToString();
    string booleanoString = booleano.ToString();

    Console.WriteLine("Inteiro para String: " + inteiroString);
    Console.WriteLine("Ponto Flutuante para String: " + pontoFlutuanteString);
    Console.WriteLine("Booleano para String: " + booleanoString);


// ===================================================
// Cast implícito e explícito
// Cast implícito ocorre quando um tipo de dado menor é atribuído a um tipo maior sem necessidade de conversão explícita
// Cast explícito ocorre quando um tipo de dado maior é convertido para um tipo menor, podendo haver perda de dados
Console.WriteLine();
Console.WriteLine("Trabalhando com cast implícito e explícito:");

    // Cast implícito Exemplo 1
    int inteiroCast = 100;
    double pontoFlutuanteCast = inteiroCast; // int para double (implícito)

    Console.WriteLine("Cast Implícito:");
    Console.WriteLine("Inteiro: " + inteiroCast);
    Console.WriteLine("Ponto Flutuante (após cast implícito): " + pontoFlutuanteCast);

    // Cast implícito Exemplo 2
    int a = int.MaxValue;
    long b = a; // int para long (implícito)
    Console.WriteLine("Cast Implícito Exemplo 2:");
    Console.WriteLine("Inteiro (int.MaxValue): " + a);
    Console.WriteLine("Long (após cast implícito): " + b);

    // Cast explícito
    double pontoFlutuanteCastEx = 123.45;
    int inteiroCastEx = (int)pontoFlutuanteCastEx; // double para int (explícito)

    Console.WriteLine("Cast Explícito:");
    Console.WriteLine("Ponto Flutuante: " + pontoFlutuanteCastEx);
    Console.WriteLine("Inteiro (após cast explícito): " + inteiroCastEx);


// ===================================================
// Ordem dos operadores em expressões matemáticas
// Ordem de precedência: (), *, /, +, -
Console.WriteLine();
Console.WriteLine("Trabalhando com ordem dos operadores em expressões matemáticas:");

    int resultado1 = 10 + 5 * 2; // Multiplicação antes da adição
    int resultado2 = (10 + 5) * 2; // Parênteses alteram a ordem

    Console.WriteLine("Resultado sem parênteses (10 + 5 * 2): " + resultado1);
    Console.WriteLine("Resultado com parênteses ((10 + 5) * 2): " + resultado2);