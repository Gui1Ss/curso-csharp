using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1Funcao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double chocolate = PrecoFinal(30, 0.25);
            double refrigerante = PrecoFinal(550, 0.25);

           
            Console.WriteLine("Chocolate com aumento de 25% " + chocolate);
            Console.WriteLine("Refrigerante com aumento de 25% " + refrigerante);
        }
        

        static double PrecoFinal(double valorInicial, double ajuste)
        {
            double resultadoFinal = valorInicial * ajuste;
            resultadoFinal = resultadoFinal + valorInicial;
            return resultadoFinal;
        }
    }
}
