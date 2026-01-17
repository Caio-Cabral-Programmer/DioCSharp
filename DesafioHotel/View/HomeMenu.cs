using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioHotel.View
{
    public static class HomeMenu
    {
        public static void ShowHomeMenu()
        {
            Console.WriteLine();
            Console.WriteLine("=== Bem-vindo ao Desafio Hotel ===");
            Console.WriteLine("--- Menu de Cadastro ---");
            Console.WriteLine("1. Cadastrar Suíte");
            Console.WriteLine("2. Cadastrar Hóspedes");
            Console.WriteLine("3. Fazer Reserva");
            Console.WriteLine("4. Realizar Pagamento");
            Console.WriteLine("5. Sair");
            Console.Write("Selecione uma opção: ");
        }
    }
}