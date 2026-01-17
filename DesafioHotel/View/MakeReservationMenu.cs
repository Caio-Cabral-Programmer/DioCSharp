using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioHotel.View
{
    public static class MakeReservationMenu
    {
        public static int ShowMakeReservationMenu()
        {
            int daysReserved = 0;

            Console.WriteLine();
            Console.WriteLine("=== Fazer Reserva ===");
            Console.WriteLine("Digite a quantidade de dias para a reserva: ");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int days))
            {
                daysReserved = days;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Definindo dias reservados como 0.");
            }
            return daysReserved;
        }
    }
}