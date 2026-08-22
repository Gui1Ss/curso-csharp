using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncaoAndArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notas = LerNotas();
            MostrarNotas(notas);
            CalcularMedia(notas);
            MaiorNota(notas);
            MenorNota(notas);

        }

        static double[] LerNotas()
        {
            double[] notas = new double[5];
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write($"Digite a nota {i + 1}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }
            return notas;
        }

        static void MostrarNotas(double[] notas)
        {
            Console.WriteLine("");
            Console.WriteLine("Notas");
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"Notas {i + 1}: {notas[i]}");
            }
        }

        static double CalcularMedia(double[] notas)
        {
            double soma = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                soma += notas[i];
            }

            double media = soma / notas.Length;
            Console.WriteLine("");
            Console.WriteLine("Média");
            Console.WriteLine($"Média: {media}");
            return media;
        }

        static double MaiorNota(double[] notas)
        {
            double maior = notas[0];
            for (int i = 1; i < notas.Length; i++)
            {
                if (maior < notas[i])
                {
                    maior = notas[i];
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Maior Nota");
            Console.WriteLine($"Maior nota: {maior}");  
            return maior;
        }

        static double MenorNota(double[] notas)
        {
            double menor = notas[0];
            for (int i = 1; i < notas.Length; i++)
            {
                if (menor > notas[i])
                {
                    menor = notas[i];
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Menor Nota");
            Console.WriteLine($"Menor nota: {menor}");
            return menor;
        }
    }
}
