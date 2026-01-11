using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

do
{
    Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" + "Digite o preço inicial:");
    string? precoInicialString = Console.ReadLine();
    if (precoInicialString != null && decimal.TryParse(precoInicialString, out precoInicial))
    {
        break;
    }
    else
    {
        Console.WriteLine("Valor inválido! Tente novamente.");
    }
} while (true);

do
{
    Console.WriteLine("Agora digite o preço por hora:");
    string? precoPorHoraString = Console.ReadLine();
    if (precoPorHoraString != null && decimal.TryParse(precoPorHoraString, out precoPorHora))
    {
        break;
    }
    else
    {
        Console.WriteLine("Valor inválido! Tente novamente.");
    }
} while (true);

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento estacionamento = new(precoInicial, precoPorHora);

string? opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (opcao = Console.ReadLine())
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;

        case "2":
            estacionamento.RemoverVeiculo();
            break;

        case "3":
            estacionamento.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou... Volte sempre!");
