using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = { "Guilherme", "Curso c#", "Palmeiras", "Animes", "Carros" };

            foreach(string palavra in palavras) //para cada palavra no array palavras, repita o bloco de código
            {
                Console.WriteLine(palavra);
                Console.WriteLine("Foreach rodando");
            }
        }
    }
}
