using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _16___FuncoesEmStructs
{
    internal class Program
    {
        struct Produto
        {
            public string nome;
            public float preco;
            public float peso;
            public string marca;

            public Produto(string nome, float preco, float peso, string marca)
            {
                this.nome = nome;
                this.preco = preco;
                this.peso = peso;
                this.marca = marca;
            }

            public void ExibirInfo()
            {
                Console.WriteLine($"Nome: {this.nome }");
                Console.WriteLine($"Preco: R${this.preco }");
                Console.WriteLine($"Peso: {this.peso } KG");
                Console.WriteLine($"Marca: {this.marca }");

            }

            public float AdicionarCupom(float porc)
            {
              float desconto =  this.preco * porc / 100f;
                return this.preco - desconto;
            }
        }

        static void Main(string[] args)
        {
            Produto iphone = new Produto("Iphone 18", 18000f, 200f, "Apple");

            Produto notebook = new Produto("Galaxy book 6", 20000f, 1800f, "Samsung");

            iphone.ExibirInfo(); //pega os campos da variavel iphone e exibe no console.
            Console.WriteLine("=================");
            notebook.ExibirInfo();

            Console.WriteLine("=================");
            Console.WriteLine("Com descontooooo");
            float valorFinal = iphone.AdicionarCupom(50f);
            Console.WriteLine(valorFinal);

        }
    }
}
