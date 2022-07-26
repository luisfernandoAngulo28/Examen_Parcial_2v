using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            clsListaS L = new clsListaS();
            clsLista p = new clsLista();
            p = L.AddS(1, 4);
            p = L.AddS(2, 3);
            p = L.AddS(3, 4);
            p = L.AddS(4, 4);
            p = L.AddS(1, 7);
            p = L.AddS(1, 9);
            p = L.AddS(2, 8);
            Console.WriteLine(p.View(p));
            Console.WriteLine(L.view());
            Console.WriteLine(L.Llena(1 - 1));
            Console.ReadKey();

        }
    }
}
