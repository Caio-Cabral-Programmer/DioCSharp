namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private readonly decimal precoInicial = 0;
        private readonly decimal precoPorHora = 0;
        private readonly List<string> veiculos = [];

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // DONE: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            do
            {
                Console.WriteLine("Digite a placa do veículo para estacionar: [digite '0' para cancelar]");
                string placaAdicionar = Console.ReadLine();

                // Verifica se a placa existe para poder adicionar
                if (veiculos.Any(placaExistente => placaExistente.ToUpper() == placaAdicionar.ToUpper()))
                {
                    Console.WriteLine("Veículo já está cadastrado!");
                }
                else
                {
                    if (placaAdicionar == "0")
                    {
                        break;
                    }
                    veiculos.Add(placaAdicionar);
                    Console.WriteLine("Veículo cadastrado com sucesso!");
                    break;
                }
            } while (true);
        }

        public void RemoverVeiculo()
        {
            // DONE: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
            // DONE: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal 
            // DONE: Remover a placa digitada da lista de veículos

            do
            {
                Console.WriteLine("Digite a placa do veículo para remover: [digite '0' para cancelar]");
                string placaRemover = Console.ReadLine();

                // Verifica se a placa existe para poder removê-la
                if (veiculos.Any(placaExistente => placaExistente.ToUpper() == placaRemover.ToUpper()))
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    string horasString = Console.ReadLine();

                    int horas = (horasString != null && horasString.All(char.IsDigit)) ? Convert.ToInt32(horasString) : 0;
                    decimal valorTotal = precoInicial + (precoPorHora * horas);

                    veiculos.Remove(placaRemover);
                    Console.WriteLine($"O veículo {placaRemover} foi removido e o preço total foi de: R$ {valorTotal}");

                    break;
                }
                else
                {
                    if (placaRemover == "0")
                    {
                        break;
                    }
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente e tente novamente.");
                }
            } while (true);
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Count != 0)
            {
                Console.WriteLine("Os veículos estacionados são:");
                // DONE: Realizar um laço de repetição, exibindo os veículos estacionados
                int contador = 1;
                foreach (string placa in veiculos)
                {
                    Console.WriteLine($"{contador}. {placa}");
                    contador++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
