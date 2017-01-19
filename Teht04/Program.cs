using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            int ika;
            Console.WriteLine("Anna ikä: ");
            string line = Console.ReadLine();
            ika = int.Parse(line);

            if (ika < 18) Console.WriteLine("Alaikäinen");
            if (ika >= 18 && ika <= 65) Console.WriteLine("Aikuinen");
            if (ika > 65) Console.WriteLine("Seniori");
        }
    }
}
