using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do raio");
            double circunferencia = double.Parse(Console.ReadLine());

            Console.WriteLine("A área do circulo é:  " + circunferencia);
        }

        double areaCirculo(double raio)
        {
            double circunferencia = (raio * 2) * Math.PI;
            return circunferencia
        }
    }
}
