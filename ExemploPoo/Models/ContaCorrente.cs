using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class ContaCorrente
    {

        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }

        public int NumeroConta { get; set; }

        private decimal Saldo { get; set; }

        public void Sacar(decimal valor)
        {
            if (valor >= Saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado com sucesso. Saldo atual: {Saldo}");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {Saldo}");
        }
    }
}