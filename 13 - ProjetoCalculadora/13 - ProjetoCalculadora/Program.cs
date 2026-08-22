using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___ProjetoCalculadora
{
    internal class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Muilitiplicacao, Potencia, Raiz, Sair };
        static void Main(string[] args)
        {
            bool escolheuSair = false;

            while (!escolheuSair)
            {
                Console.WriteLine("Seja bem vindo(a) ao CALC, selecione uma das opções:");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potencia\n6-Raiz\n7-Sair");
                Console.WriteLine("====================");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;

                    case Menu.Subtracao:
                        Subtracao();
                        break;

                    case Menu.Divisao:
                        Div();
                        break;

                    case Menu.Muilitiplicacao:
                        Mult();
                        break;

                    case Menu.Potencia:
                        Potencia();
                        break;

                    case Menu.Raiz:
                        Raiz();
                        break;

                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }

                Console.WriteLine(opcao);
                Console.Clear();
            }
        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois números");
            Console.WriteLine("Digte o primeiro número: ");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Digte o segundo número: ");
            float b = float.Parse(Console.ReadLine());

            float resultado = a + b;

            Console.WriteLine($"Resultado de {a} + {b} é {resultado}");
            Console.WriteLine("Aperte enter para voltar ao menu");
            Console.ReadLine();
        }

        static void Subtracao()
        {
            Console.WriteLine("Subtração de dois números");
            Console.WriteLine("Digite o primero número: ");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            float b = float.Parse(Console.ReadLine());

            float resultado = a - b;

            Console.WriteLine($"Resultado de {a} - {b} é {resultado}");
            Console.WriteLine("Aperte enter para voltar ao menu");
            Console.ReadLine();
        }

        static void Mult()
        {
            Console.WriteLine("Multiplicação de dois números");
            Console.WriteLine("Digite o primero número: ");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            float b = float.Parse(Console.ReadLine());

            float resultado = a * b;

            Console.WriteLine($"Resultado de {a} * {b} é {resultado}");
            Console.WriteLine("Aperte enter para voltar ao menu");
            Console.ReadLine();
        }

        static void Div()
        {
            Console.WriteLine("Divisão de dois números");
            Console.WriteLine("Digite o primero número: ");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            float b = float.Parse(Console.ReadLine());

            float resultado = a / b;

            Console.WriteLine($"Resultado de {a} / {b} é {resultado}");
            Console.WriteLine("Aperte enter para voltar ao menu");
            Console.ReadLine();
        }

        static void Potencia()
        {
            Console.WriteLine("Potência de dois números");
            Console.WriteLine("Digite o primero número: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double b = double.Parse(Console.ReadLine());

            double resultado = Math.Pow(a, b);

            Console.WriteLine($"Resultado da potência de {a} e {b} é {resultado}");
            Console.WriteLine("Aperte enter para voltar ao menu");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("Raiz Quadrada de um número");

            double a = double.Parse(Console.ReadLine());

            double resultado = Math.Sqrt(a);

            Console.WriteLine($"Resultado da raiz de {a} é {resultado}");
            Console.WriteLine("Aperte enter para voltar ao menu");
            Console.ReadLine();
        }
    }
}