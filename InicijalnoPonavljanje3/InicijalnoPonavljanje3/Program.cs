using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanje3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Napišite program u kojem ćete deklarirati varijable a i b tipa int, 
             * c i d tipa double, dodijelite im vrijednosti 10, 7, 12.5 i 16.7, te izračunajte prosječnu vrijednost.
            */
            int a = 10, b = 7;
            double c = 12.5, d= 16.7;
            Console.WriteLine("Prosječna vrijednost: " + ((a + b + c + d) / 4));
            Console.ReadKey();
            
        }
    }
}
