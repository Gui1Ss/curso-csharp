using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            do
            {
                Console.WriteLine("do while"); //funciona exatamente igual o while, mas mesmo se a condição for verdadeira ele vai executar pelo menos 1 vez
                cont++;
            } while (cont < 10);

            /*do
            {
                Console.WriteLine("do while"); //funciona exatamente igual o while, mas mesmo se a condição for verdadeira ele vai executar pelo menos 1 vez
                cont++;
            } while (1000 < 10);*/
        }
    }
}
