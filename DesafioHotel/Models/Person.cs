using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioHotel.Models
{
    public class Person(string name, string lastName) // Construtor primário
    {
        public string? Name { get; set; } = name;
        public string? LastName { get; set; } = lastName;
        public string? FullName => $"{Name} {LastName}";
    }
}