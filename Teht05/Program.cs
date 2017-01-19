using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku, sek, min, tunti;

            Console.WriteLine("Anna sekunnit: ");
            string line = Console.ReadLine();
            luku = int.Parse(line);
            tunti = luku / (60 * 60);
            min = luku / 60 - tunti * 60;
            sek = luku % 60;
            
            Console.WriteLine("Antamasi sekunttiaika voidaan ilmaista muodossa: " + tunti +" tuntia " + min +" minuuttia " + sek +" sekunttia ");
        }
    }
}
