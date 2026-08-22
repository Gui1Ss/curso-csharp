using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___Enum
{
    internal class Program
    {
            enum Cor  { Azul = 1, Amarelo, Verde, Vermelho, Preto }; // todos esses valores tem um valor numerico, azul começa 1 e o resto acompanha, mas se eu nao setar o valor 1 ele começa com 0 

        static void Main(string[] args)
        {

            Cor corFavorita = Cor.Preto;
            Cor corFavoritaMaria = Cor.Azul;

            Console.WriteLine((int)corFavorita); //cast = converter um tipo pelo outro. ele nao vai exibir preto e sim 5
            Console.WriteLine(corFavoritaMaria);

            Console.WriteLine((Cor)5);
            


        }
    }
}
