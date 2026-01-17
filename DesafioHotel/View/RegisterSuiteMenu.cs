using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioHotel.Models;

namespace DesafioHotel.View
{
    public static class RegisterSuiteMenu
    {
        public static Suite? ShowSuiteRegistrationMenu()
        {
            Console.WriteLine("=== Cadastro de Suíte ===");
            Console.Write("Tipo da Suíte [Premium, Luxo, Standard]: ");
            string? suiteType = Console.ReadLine();
            if (suiteType == null) return null;

            Console.Write("Capacidade da Suíte [2, 4, 6]: ");
            if (!int.TryParse(Console.ReadLine(), out int capacity))
            {
                Console.WriteLine("Capacidade inválida. Tente novamente.");
                return null; // Ou repita o loop, dependendo da lógica
            }

            Console.Write("Valor Diário da Suíte: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal dailyValue))
            {
                Console.WriteLine("Valor inválido. Tente novamente.");
                return null;
            }

            Suite suite = new Suite(suiteType, capacity, dailyValue);

            Console.WriteLine("Suíte cadastrada com sucesso!");

            return suite;
        }
    }
}