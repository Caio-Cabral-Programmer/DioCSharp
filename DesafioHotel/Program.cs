using DesafioHotel.Models;
using DesafioHotel.View;
using System.Globalization;

Reservation reservation = new Reservation(null!, [], 0);

bool menu = true;

do
{
    HomeMenu.ShowHomeMenu();
    string? selectedOption = Console.ReadLine();

    switch (selectedOption)
    {
        case "1": // Cadastrar Suíte

            Suite? suite = RegisterSuiteMenu.ShowSuiteRegistrationMenu();
            if (suite != null)
            {
                reservation.Suite = suite;
            }

            break;

        case "2": // Cadastrar Hóspedes

            List<Person> guestsList = RegisterGuestsMenu.ShowRegisterGuestsMenu();
            if (guestsList.Count > 0)
            {
                try
                {
                    reservation.Guests = guestsList;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Nenhum hóspede foi cadastrado. Tente novamente.");
            }

            break;

        case "3": // Fazer Reserva

            int daysReserved = MakeReservationMenu.ShowMakeReservationMenu();
            if (daysReserved > 0)
            {
                reservation.DaysReserved = daysReserved;
                Console.WriteLine("Reserva realizada com sucesso!");
                Console.WriteLine("Seguem os detalhes da reserva:");
                Console.WriteLine($"- Suíte: {reservation.Suite.SuiteType}");
                Console.WriteLine($"- Capacidade: {reservation.Suite.Capacity} hóspedes");
                Console.WriteLine($"- {reservation.Guests.Count} hóspedes: {string.Join(", ", reservation.Guests.Select(g => g.FullName))}");
                Console.WriteLine($"- Dias Reservados: {reservation.DaysReserved} dias");

            }
            else
            {
                Console.WriteLine("Dias reservados inválidos. Tente novamente.");
            }

            break;
        case "4": // Realizar Pagamento

            Console.WriteLine();
            Console.WriteLine("=== Realizar Pagamento ===");
            Console.WriteLine("=-= Descontos de 10% para reservas de 10 dias ou mais =-=");
            Console.WriteLine("Seguem os detalhes da reserva:");
            Console.WriteLine($"- Suíte: {reservation.Suite.SuiteType}");
            Console.WriteLine($"- Capacidade: {reservation.Suite.Capacity} hóspedes");
            Console.WriteLine($"- {reservation.Guests.Count} hóspedes: {string.Join(", ", reservation.Guests.Select(g => g.FullName))}");
            Console.WriteLine($"- Dias Reservados: {reservation.DaysReserved} dias");

            if (reservation.DaysReserved >= 10)
            {
                Console.WriteLine($"- Valor Total (Desconto de 10%): {reservation.GetTotalPrice().ToString("C", new CultureInfo("pt-BR"))}");

            }
            else
            {
                Console.WriteLine($"- Valor Total (Sem desconto): {reservation.GetTotalPrice().ToString("C", new CultureInfo("pt-BR"))}");
            }

            break;

        case "5": // Sair

            Console.WriteLine("Saindo do sistema. Até logo!");
            menu = false;
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }

} while (menu);
