using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioHotel.Models
{

    public class Reservation
    {
        public Reservation(Suite suite, List<Person> guests, int daysReserved) // Construtor primário
        {
            Suite = suite;
            Guests = guests;
            DaysReserved = daysReserved;
        }

        public Suite Suite { get; set; }
        public List<Person> Guests { get; set; }
        public int DaysReserved { get; set; }

        public decimal GetTotalPrice()
        {
            decimal total = DaysReserved * Suite.DailyValue;

            if (DaysReserved >= 10)
            {
                total *= 0.9m; // Aplica 10% de desconto
            }

            return total;
        }

    }
}