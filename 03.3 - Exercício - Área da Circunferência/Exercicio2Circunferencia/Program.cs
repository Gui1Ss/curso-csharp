using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2Circunferencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double area = areaCirculo(raio);

            Console.Write("A área do circulo é:  "  + area);
        }

        static double areaCirculo(double raio)
        {
            return Math.PI * raio * raio;
        }
    }
}


