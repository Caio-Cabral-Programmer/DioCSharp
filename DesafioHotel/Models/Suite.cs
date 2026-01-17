using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioHotel.Models
{
    public class Suite(string suiteType, int capacity, decimal dailyValue) // Construtor primário
    {
        public string SuiteType { get; set; } = suiteType;
        public int Capacity { get; set; } = capacity;
        public decimal DailyValue { get; set; } = dailyValue;
    }
}