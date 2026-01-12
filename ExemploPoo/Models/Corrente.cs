using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"Crédito de {valor:C} realizado com sucesso na conta corrente.");
        }
    }
}