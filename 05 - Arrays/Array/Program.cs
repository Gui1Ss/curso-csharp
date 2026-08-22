using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] produtos = new string[5]
                {"Minecraft", "Fifa", "Code", "Fortnite", "Balatro" };

            int[] valoress = { 30, 50, 60, 70, 80 };

            produtos[1] = "Fifa 2026";
            //Console.WriteLine(produtos[1]);

            for (int i = 0; i < produtos.Length; i++)
            {
                Console.WriteLine(produtos[i]);
                Console.WriteLine(valoress[i]);
            }
            
        }
    }
}
