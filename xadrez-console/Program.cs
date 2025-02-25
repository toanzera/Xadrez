using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez_console.Tabuleiro;
namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;
            P = new Posicao(1, 2);
            Console.WriteLine(P);
        }
    }
}