using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _15___Constructor
{
    internal class Program
    {
        struct Produto
        {
            public string nome;
            public float preco;
            public float peso;
            public string marca;

            public Produto(string nome,float preco, float peso, string marca)
            {
                this.nome = nome;
                this.preco = preco;
                this.peso = peso;
                this.marca = marca;
            }
        }
        static void Main(string[] args)
        {
            Produto iphone = new Produto("Iphone 18", 18000f, 200f, "Apple");

            Produto notebook = new Produto("Galaxy book 6", 20000f, 1800f, "Samsung");
        }
    }
}
