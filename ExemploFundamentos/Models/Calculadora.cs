using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public static class Calculadora
    {
        public static void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public static void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public static void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} X {y} = {x * y}");
        }

        public static void Dividir(int x, int y)
        {
            if (y != 0)
            {
                Console.WriteLine($"{x} / {y} = {x / y}");
            }
            else
            {
                Console.WriteLine("Divisão por zero não é permitida.");
            }
        }

        public static void Potencia(int x, int y)
        {
            double potencia = Math.Pow(x, y);
            Console.WriteLine($"{x} elevado a {y} = {potencia}");
            Console.WriteLine($"{x} ^ {y} = {potencia}");
        }

        public static void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}° = {seno}");
        }
        public static void Cosseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double cosseno = Math.Cos(radiano);
            Console.WriteLine($"Cosseno de {angulo}° = {cosseno}");
        }
        public static void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}° = {tangente}");
        }
    }
}