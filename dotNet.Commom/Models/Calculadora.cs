using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNet.Commom.Models
{
    public class Calculadora
    {
        /// <summary>
        /// Calcula a soma de dois números
        /// </summary>
        /// <param name="x">O primeiro número inteiro</param>
        /// <param name="y">O segundo número inteiro</param>
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
            Console.WriteLine($"{x} ^ {y} = {Math.Pow(x, y)}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * (Math.PI / 180);
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}");
        }

        public void Cosseno(double angulo)
        {
            double radiano = angulo * (Math.PI / 180);
            double cosseno = Math.Cos(radiano);
            Console.WriteLine($"Cosseno de {angulo}° = {Math.Round(cosseno, 4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * (Math.PI / 180);
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada(double numero)
        {
            double raiz = Math.Sqrt(numero);
            Console.WriteLine($"Raiz quadrada de {numero} = {Math.Round(raiz, 4)}");
        }
    }
}