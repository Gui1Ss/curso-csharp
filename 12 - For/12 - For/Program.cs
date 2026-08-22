using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___For
{
    internal class Program
    {
        static void Main(string[] args)
        { 

        
            string[] palavras = { "Guilherme", "Carro", "UFC" };
            for (int cont = 0; cont < palavras.Length; cont++) 
            {
                Console.WriteLine(cont);
                Console.WriteLine(palavras[cont]);
            }
            Console.WriteLine("=================");
            for (int cont2 = palavras.Length; cont2 >= 0; cont2--) 
            {
                Console.WriteLine(cont2);
                Console.WriteLine(palavras[cont2]);

            }

        }
    }
}
