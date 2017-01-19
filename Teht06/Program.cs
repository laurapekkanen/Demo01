using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            double kulutus = 7.02/100;
            double hinta = 1.595;
            double matka;

            Console.WriteLine("Anna matka: ");
            string line = Console.ReadLine();
            matka = double.Parse(line);
            Console.WriteLine("Benasaa kuluu: " + matka*kulutus + " litraa, " +  "kustannus " + matka*kulutus*hinta + " eurooa");
        }
    }
}
