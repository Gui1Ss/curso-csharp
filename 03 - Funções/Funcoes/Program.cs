using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ExibirMensagen();
            GerarPreco(18.90);
        }

        static void ExibirMensagen()
        {
            Console.WriteLine("Olá, mundo!");
            Console.WriteLine("Bem-vindo");
        }

        static void GerarPreco(double preco)
        {
            double precoAbs = Math.Abs(preco);
            double valorFinal =  precoAbs + (2 * precoAbs);
            Console.WriteLine("Valor final: " + valorFinal);
        }
    }
}
