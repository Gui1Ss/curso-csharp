using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___Struct
{
    internal class Program
    {

        struct Produto
        {
            public string nome;
            public float preco;
            public float peso;
            public string marca;
        }
        static void Main(string[] args)
        {
            Produto bola = new Produto();
            bola.nome = "Bola da copa 2026";
            bola.preco = 120f;
            bola.peso = 0.8f;
            bola.marca = "Adidas";

            Produto chuteira = new Produto();
            chuteira.nome = "Mercurial 7";
            chuteira.preco = 500f;
            chuteira.peso = 0.4f;
            chuteira.marca = "Nike";
        }
    }
}
