using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___ListaNull
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> clientes = new List<string>();
            clientes.Add("Guilherme");
            clientes.Add("Souto");
            string pessoa = "José";
            clientes.Add(pessoa);

            foreach (string cliente in clientes)
            {
                Console.WriteLine(cliente);
            }

            //string busca = clientes.Find(cliente => cliente.Length > 14); // retorna o primeiro elemento que encontrar 

            List<string> filtrada = clientes.FindAll(cliente => cliente.Length > 4);
            Console.WriteLine("=======================");

            foreach (string cliente in filtrada)
            {
                Console.WriteLine(cliente);
            }


            Console.ReadLine();
        }
    }
}
