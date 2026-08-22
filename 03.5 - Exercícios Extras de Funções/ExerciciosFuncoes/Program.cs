using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFuncoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            String entrada = Console.ReadLine();
            int num = int.Parse(entrada);
            Console.WriteLine($"O dobro é: {CalcularDobro(num)}");
            int dobro = CalcularDobro(num);
            Console.Write($"O quadrado é: {dobro}");
        }

        static int CalcularDobro(int num)
        {
            double resultado = Math.Pow(num, 2);
            return (int)resultado;
        }
        
    }
}
