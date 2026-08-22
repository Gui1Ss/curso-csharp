using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string[] alunos = { "Guilherme", "Maria Clara", "Eduarda", "Fernanda", "Jennifer", "Gabriela", "Myllena", "Anna Paula", "Livia", "Rebeca" };

            int i = 1;
            foreach (string nomes in alunos)
            {
                Console.WriteLine( i + " Bem vindo(a) " + nomes);
                i++;
            }*/

            /*for(int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }*/

            for(int velocidade = 100; velocidade <=  220;  velocidade++)
            {
                if(velocidade >= 200)
                {
                    Console.WriteLine("Você esta ultrapassando a velocidade permitida de 200km/h e sua velocidade atual é de " + velocidade);
                }
                else
                {
                    Console.WriteLine("Você esta na velocidade permitida de 200km/h e sua velocidade atual é de " + velocidade);
                }
            }
        }
    }
}
