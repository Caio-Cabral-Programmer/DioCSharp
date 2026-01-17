using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioHotel.Models;

namespace DesafioHotel.View
{
    public static class RegisterGuestsMenu
    {
        public static List<Person> ShowRegisterGuestsMenu()
        {
            List<Person> guestsList = [];

            do
            {
                Console.WriteLine();
                Console.WriteLine("=== Cadastro de Hóspedes ===");
                Console.Write("Digite o nome do hóspede: [digite '0' para finalizar] ");
                string? guestName = Console.ReadLine();
                if (guestName == "0") break;
                if (guestName == null) continue;

                Console.Write("Digite o sobrenome do hóspede: [digite '0' para finalizar] ");
                string? guestLastName = Console.ReadLine();
                if (guestLastName == "0") break;
                if (guestLastName == null) continue;

                guestsList.Add(new Person(guestName, guestLastName));

            } while (true);

            if (guestsList.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Hóspedes cadastrados:");
                foreach (var guest in guestsList)
                {
                    Console.WriteLine($"- {guest.Name} {guest.LastName}");
                }

                return guestsList;
            }
            else
            {
                Console.WriteLine("Nenhum hóspede foi cadastrado.");
                return [];
            }

            
        }
    }
}