using ExemploFundamentos.Common.Models;

// ===================================================
// Instanciando um objeto da classe Pessoa:
Console.WriteLine("Instanciando um objeto da classe Pessoa:");
Console.WriteLine();

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
// pessoa1.Apresentar();


// ===================================================
// Tipos de dados comuns em C#:
Console.WriteLine();
Console.WriteLine("Tipos de dados comuns em C#:");
Console.WriteLine();


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
Console.WriteLine();

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
Console.WriteLine();

    DateTime dataAtual = DateTime.Now;

    Console.WriteLine("Data e hora atual: " + dataAtual);
    Console.WriteLine("Data atual: " + dataAtual.ToString("dd/MM/yyyy"));
    Console.WriteLine("Hora atual: " + dataAtual.ToString("HH:mm"));


// ===================================================
// Constantes
// Constantes são variáveis cujo valor não pode ser alterado durante a execução do programa
Console.WriteLine();
Console.WriteLine("Trabalhando com constantes:");
Console.WriteLine();

    const double PI = 3.14;

    Console.WriteLine("Valor de PI: " + PI);


// ===================================================
// Conversão de tipos, chamado de Cast ou Type Casting em inglês
// Utiliza-se o método Convert para converter tipos de dados, Parse para converter strings e TryParse para tentar converter strings sem lançar exceção
// Convert, Parse e TryParse - Diferença → Convert lida com valores nulos, Parse não e TryParse tenta converter sem lançar exceção
// TryParse é mais seguro para conversão de strings, pois evita exceções em caso de falha e seu uso é recomendado quando a entrada pode ser incerta
 
Console.WriteLine();
Console.WriteLine("Trabalhando com conversão de tipos:");
Console.WriteLine();

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
Console.WriteLine();

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
Console.WriteLine();

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
Console.WriteLine();

    int resultado1 = 10 + 5 * 2; // Multiplicação antes da adição
    int resultado2 = (10 + 5) * 2; // Parênteses alteram a ordem

    Console.WriteLine("Resultado sem parênteses (10 + 5 * 2): " + resultado1);
    Console.WriteLine("Resultado com parênteses ((10 + 5) * 2): " + resultado2);


// ===================================================
// Operadores condicionais
// if, else if, else, switch e operador ternário
Console.WriteLine();
Console.WriteLine("Trabalhando com operadores condicionais:");
Console.WriteLine();

    // Exemplo 1 com ||:
    Console.WriteLine("Digite uma letra:");
    string? letra = Console.ReadLine();

    if (letra == "a" || 
        letra == "e" || 
        letra == "i" || 
        letra == "o" || 
        letra == "u")
    {
        Console.WriteLine("A letra é uma vogal.");
    }
    else
    {
        Console.WriteLine("A letra não é uma vogal.");
    }

    // Exemplo 2 com switch
    Console.WriteLine();
    Console.WriteLine("Digite uma letra:");
    letra = Console.ReadLine();

    switch (letra)
    {
        case "a":
        case "e":
        case "i":
        case "o":
        case "u":
            Console.WriteLine("A letra é uma vogal.");
            break;
        default:
            Console.WriteLine("A letra não é uma vogal.");
            break;
    }

    // Exemplo 3 com switch
    int diaDaSemana = 3;
    switch (diaDaSemana)
    {
        case 1:
            Console.WriteLine("Domingo");
            break;
        case 2:
            Console.WriteLine("Segunda-feira");
            break;
        case 3:
            Console.WriteLine("Terça-feira");
            break;
        case 4:
            Console.WriteLine("Quarta-feira");
            break;
        case 5:
            Console.WriteLine("Quinta-feira");
            break;
        case 6:
            Console.WriteLine("Sexta-feira");
            break;
        case 7:
            Console.WriteLine("Sábado");
            break;
        default:
            Console.WriteLine("Dia inválido");
            break;
    }

    // Exemplo 4 com switch moderno (C# 8.0+)
    string diaSemanaString = diaDaSemana switch
    {
        1 => "Domingo",
        2 => "Segunda-feira",
        3 => "Terça-feira",
        4 => "Quarta-feira",
        5 => "Quinta-feira",
        6 => "Sexta-feira",
        7 => "Sábado",
        _ => "Dia inválido"
    };
    Console.WriteLine("Dia da semana (switch moderno): " + diaSemanaString);


    // Exemplo 5 com &&:
    int numeroCondicional = 15;

    if (numeroCondicional < 10)
    {
        Console.WriteLine("Número é menor que 10.");
    }
    else if (numeroCondicional >= 10 && numeroCondicional <= 20)
    {
        Console.WriteLine("Número está entre 10 e 20.");
    }
    else
    {
        Console.WriteLine("Número é maior que 20.");
    }

    // Exemplo 6 com operador ternário
    string resultadoTernario = (numeroCondicional % 2 == 0) ? "Número é par." : "Número é ímpar.";
    Console.WriteLine("Resultado com operador ternário: " + resultadoTernario);


// ===================================================
// Operadores lógicos
// && (E), || (OU), ! (NÃO)
Console.WriteLine();
Console.WriteLine("Trabalhando com operadores lógicos:");
Console.WriteLine();

    bool condicao1 = true;
    bool condicao2 = false;
    bool condicao3 = true;
    bool condicao4 = false;

    // Operador E (&&)
    bool resultadoE = condicao1 && condicao2;
    Console.WriteLine("Resultado do operador E (true && false): " + resultadoE);
    Console.WriteLine("Resultado do operador E (true && true): " + (condicao1 && condicao3));
    Console.WriteLine("Resultado do operador E (false && false): " + (condicao2 && condicao4));

    // Operador OU (||)
    bool resultadoOU = condicao1 || condicao2;
    Console.WriteLine("Resultado do operador OU (true || false): " + resultadoOU);
    Console.WriteLine("Resultado do operador OU (false || false): " + (condicao2 || condicao4));
    Console.WriteLine("Resultado do operador OU (true || true): " + (condicao1 || condicao3));

    // Operador NÃO (!)
    bool resultadoNAO = !condicao1;
    Console.WriteLine("Resultado do operador NÃO (!true): " + resultadoNAO);
    Console.WriteLine("Resultado do operador NÃO (!false): " + !condicao2);


// ===================================================
// Operadores Aritméticos
// +, -, *, /, %, ++, --
Console.WriteLine();
Console.WriteLine("Trabalhando com operadores aritméticos:");
Console.WriteLine();

    // Exemplo 1:
    int aAritmeticos = 10;
    int bAritmeticos = 3;

    Console.WriteLine("Soma (10 + 3): " + (aAritmeticos + bAritmeticos));
    Console.WriteLine("Subtração (10 - 3): " + (aAritmeticos - bAritmeticos));
    Console.WriteLine("Multiplicação (10 * 3): " + (aAritmeticos * bAritmeticos));
    Console.WriteLine("Divisão (10 / 3): " + (aAritmeticos / bAritmeticos));
    Console.WriteLine("Módulo (10 % 3): " + (aAritmeticos % bAritmeticos));

    // Incremento
    aAritmeticos++;
    Console.WriteLine("Incremento (a++): " + aAritmeticos);

    // Decremento
    bAritmeticos--;
    Console.WriteLine("Decremento (b--): " + bAritmeticos);


    // Exemplo 2 com a classe Calculadora
    Console.WriteLine();
    Console.WriteLine("Utilizando a classe Calculadora:");
    Calculadora.Somar(10, 3);
    Calculadora.Subtrair(10, 3);
    Calculadora.Multiplicar(10, 3);
    Calculadora.Dividir(10, 3);
    Calculadora.Dividir(10, 0);


// ===================================================
// Operações Matemáticas Complexas
// Math.Pow, Math.Sqrt, Math.Abs, Math.Round, Math.Ceiling, Math.Floor
Console.WriteLine();
Console.WriteLine("Trabalhando com operações matemáticas complexas:");
Console.WriteLine();

    // Exemplo 1:
    double numeroMath = 16.0;

    Console.WriteLine("Número: " + numeroMath);
    Console.WriteLine("Potência (Math.Pow(numero, 2)): " + Math.Pow(numeroMath, 2));
    Console.WriteLine("Raiz Quadrada (Math.Sqrt(numero)): " + Math.Sqrt(numeroMath));
    Console.WriteLine("Valor Absoluto (Math.Abs(-numero)): " + Math.Abs(-numeroMath));
    Console.WriteLine("Arredondar (Math.Round(15.67)): " + Math.Round(15.67));
    Console.WriteLine("Arredondar para cima (Math.Ceiling(15.12)): " + Math.Ceiling(15.12));
    Console.WriteLine("Arredondar para baixo (Math.Floor(15.89)): " + Math.Floor(15.89));

    // Exemplo 2 com a classe Calculadora
    Console.WriteLine();
    Console.WriteLine("Utilizando a classe Calculadora para potência:");
    Calculadora.Potencia(5, 3);

    // Exemplo 3 com a classe Calculadora
    Console.WriteLine();
    Console.WriteLine("Utilizando a classe Calculadora para seno, cosseno e tangente:");
    Calculadora.Seno(30);
    Calculadora.Cosseno(30);
    Calculadora.Tangente(30);


// ===================================================
// Estruturas de repetição
// for, while, do while, foreach
Console.WriteLine();
Console.WriteLine("Trabalhando com estruturas de repetição:");
Console.WriteLine();

    // Exemplo 1 com for
    Console.WriteLine("Exemplo com for:");
    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine("Contador for: " + i);
    }

    // Exemplo 2 com while
    Console.WriteLine();
    Console.WriteLine("Exemplo com while:");
    int contadorWhile = 1;
    while (contadorWhile <= 5)
    {
        Console.WriteLine("Contador while: " + contadorWhile);
        contadorWhile++;
    }

    // Exemplo 3 com do while
    Console.WriteLine();
    Console.WriteLine("Exemplo com do while:");
    int contadorDoWhile = 1;
    do
    {
        Console.WriteLine("Contador do while: " + contadorDoWhile);
        contadorDoWhile++;
    } while (contadorDoWhile <= 5);

    // Exemplo 4 com foreach
    Console.WriteLine();
    Console.WriteLine("Exemplo com foreach:");
    string[] frutas = { "Maçã", "Banana", "Laranja", "Uva", "Manga" };
    foreach (string fruta in frutas)
    {
        Console.WriteLine("Fruta: " + fruta);
    }

    // Exemplo 5 com break e continue com for
    Console.WriteLine();
    Console.WriteLine("Exemplo com break e continue:");
    for (int i = 1; i <= 10; i++)
    {
        if (i == 6)
        {
            Console.WriteLine("Interrompendo o loop quando i é igual a 6 (break).");
            break; // sai do loop quando i é 6
        }

        if (i % 2 == 0)
        {
            Console.WriteLine("Pulando números pares (continue).");
            continue; // pula os números pares
        }

        Console.WriteLine("Número ímpar: " + i);
    }

    // Exemplo 6 com break e continue com while
    Console.WriteLine();
    Console.WriteLine("Exemplo com break e continue em while:");
    int contadorBreakContinue = 1;
    while (contadorBreakContinue <= 10)
    {
        if (contadorBreakContinue == 6)
        {
            Console.WriteLine("Interrompendo o loop quando contador é igual a 6 (break).");
            break; // sai do loop quando contador é 6
        }

        if (contadorBreakContinue % 2 == 0)
        {
            Console.WriteLine("Pulando números pares (continue).");
            contadorBreakContinue++;
            continue; // pula os números pares
        }

        Console.WriteLine("Número ímpar: " + contadorBreakContinue);
        contadorBreakContinue++;
    }

    // Exemplo 7 com menu interativo usando while
    Console.WriteLine();
    Console.WriteLine("Exemplo de menu interativo com while:");
    string? opcao;
    do
    {
        Console.WriteLine();
        Console.WriteLine("Menu:");
        Console.WriteLine("1 - Opção 1");
        Console.WriteLine("2 - Opção 2");
        Console.WriteLine("3 - Sair");
        Console.Write("Escolha uma opção: ");
        opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.WriteLine("Você escolheu a Opção 1.");
                break;
            case "2":
                Console.WriteLine("Você escolheu a Opção 2.");
                break;
            case "3":
                Console.WriteLine("Saindo do menu.");
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    } while (opcao != "3");


// ===================================================
// Arrays e Coleções
// Array, List, Dictionary
Console.WriteLine();
Console.WriteLine("Trabalhando com arrays e coleções:");
Console.WriteLine();

    // Exemplo 1 com Array
    Console.WriteLine("Exemplo com Array:");
    int[] numerosArray = new int[5] { 10, 20, 30, 40, 50 };
    for (int i = 0; i < numerosArray.Length; i++)
    {
        Console.WriteLine("Número no array: " + numerosArray[i]);
    }

    // Exemplo 2 com List
    Console.WriteLine();
    Console.WriteLine("Exemplo com List:");
    List<string> frutasList = new List<string> { "Maçã", "Banana", "Laranja" };
    frutasList.Add("Uva");
    frutasList.Add("Manga");
    foreach (string fruta in frutasList)
    {
        Console.WriteLine("Fruta na lista: " + fruta);
    }

    // Exemplo 3 com Dictionary
    Console.WriteLine();
    Console.WriteLine("Exemplo com Dictionary:");
    Dictionary<string, string> capitais = new Dictionary<string, string>();
    capitais.Add("Brasil", "Brasília");
    capitais.Add("Portugal", "Lisboa");
    capitais.Add("Espanha", "Madri");
    foreach (KeyValuePair<string, string> item in capitais)
    {
        Console.WriteLine("País: " + item.Key + ", Capital: " + item.Value);
    }

    // Exemplo 4 com Dictionary com inicialização simplificada
    Console.WriteLine();
    Console.WriteLine("Exemplo com Dictionary (inicialização simplificada):");
    Dictionary<string, string> capitaisSimplificado = new Dictionary<string, string>
    {
        { "França", "Paris" },
        { "Itália", "Roma" },
        { "Alemanha", "Berlim" }
    };
    foreach (var item in capitaisSimplificado)
    {
        Console.WriteLine("País: " + item.Key + ", Capital: " + item.Value);
    }

    // Exemplo 5 com Array e Array.Resize
    Console.WriteLine();
    Console.WriteLine("Exemplo com Array e Array.Resize:");
    int[] numerosArrayResize = new int[3] { 1, 2, 3 };
    foreach (int numero in numerosArrayResize)
    {
        Console.WriteLine("Número no array: " + numero);
    }

    Array.Resize(ref numerosArrayResize, 5); // redimensiona o array para tamanho 5
    numerosArrayResize[3] = 4;
    numerosArrayResize[4] = 5;
    foreach (int numero in numerosArrayResize)
    {
        Console.WriteLine("Número no array redimensionado: " + numero);
    }

    // Exemplo 6 com Array e Array.Copy
    Console.WriteLine();
    Console.WriteLine("Exemplo com Array e Array.Copy:");
    int[] origem = new int[5] { 10, 20, 30, 40, 50 };
    int[] destino = new int[5];
    foreach (int numero in destino)
    {
        Console.WriteLine("Número no array destino: " + numero);
    }

    Array.Copy(origem, destino, origem.Length);
    foreach (int numero in destino)
    {
        Console.WriteLine("Número no array destino após Array.Copy: " + numero);
    }

    // Exemplo 5 com List e métodos comuns
    Console.WriteLine();
    Console.WriteLine("Exemplo com List e métodos comuns:");
    List<string> carros = new List<string> { "Gol", "Uno", "Palio" };
    foreach (string carro in carros)
    {
        Console.WriteLine("Carro na lista: " + carro);
    }

    carros.Add("Civic");
    foreach (string carro in carros)
    {
        Console.WriteLine("Carro na lista depois do add: " + carro);
    }

    carros.Remove("Uno");
    foreach (string carro in carros)
    {
        Console.WriteLine("Carro na lista depois do remove: " + carro);
    }

    carros.Sort();
    foreach (string carro in carros)
    {
        Console.WriteLine("Carro na lista depois do sort: " + carro);
    }