using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___EnumSwitch
{
    internal class Program
    {
        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar}


        static void Main(string[] args)
        {
            Console.Write("Selecione uma das opções");
            Console.WriteLine("1-Criar\n2-Deletar\n-3Editar\n4-Listar\n5-Atualizar");

            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;

            switch(opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Voce quer criar algo");
                    break;

                case Opcao.Deletar:
                    Console.WriteLine("Voce quer deletar algo");
                    break;

                case Opcao.Editar:
                    Console.WriteLine("Voce quer editar algo");
                    break;


                case Opcao.Listar:
                    Console.WriteLine("Voce quer listar algo");
                    break;

                case Opcao.Atualizar:
                    Console.WriteLine("Voce quer atualizar algo");
                    break;

                default:
                    Console.WriteLine("Opcao não encontrada");
                    break;
            }
        }
    }
}
