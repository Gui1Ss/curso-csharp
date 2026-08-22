using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncaoRetorno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma1 = Somar(10, 20, 455);
            Console.WriteLine(soma1);
        }

        static int Somar(int a, int b, int c)
        {
            int resultadoFinal = a + b + c;
            return resultadoFinal;
        }
    }
}
