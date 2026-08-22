using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area = calculaTriangulo(250, 350);
            Console.WriteLine("A área do triângulo é: "+ area);
        }

        static double calculaTriangulo(double baseTri, double altura)
        {
            return (baseTri * altura) / 2;
        }
    }
}
