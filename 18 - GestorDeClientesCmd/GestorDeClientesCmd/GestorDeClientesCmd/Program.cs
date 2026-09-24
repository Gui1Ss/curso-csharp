using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GestorDeClientesCmd
{
    internal class Programls
    {

        enum Menu  {Listagem = 1, Adicionar, Remover, Sair}
        static void Main(string[] args)
        {
            bool escolheuSair = false;

            while (!escolheuSair)
            {
                Console.WriteLine("Sistema de clientes - Bem vindo!");
                Console.WriteLine("1-Listagem\n2-Adicionar\n3-Remover\n4-Sair");

                int intOp = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)intOp;

                switch (opcao)
                {
                    case Menu.Listagem:
                        break;
                    case Menu.Adicionar:
                        break;
                    case Menu.Remover:
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;

                }

                Console.Clear();
            }


        }
    }
}
