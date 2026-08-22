using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            while(cont < 10)
            {
                Console.WriteLine(cont + 1);
                Console.WriteLine("Infinito");
                cont++;
            }
                Console.WriteLine("Fim da linha");
        }
    }
}
