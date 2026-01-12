using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        public int Dividir(int num1, int num2) // Método com implementação padrão, ou seja, a classe que implementar a interface pode optar por usar ou sobrescrever esse método
        {
            return num1 / num2;
        }
    }
}