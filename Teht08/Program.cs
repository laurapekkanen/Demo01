using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht08
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3;

            Console.WriteLine("Anna luku 1: ");
            string line = Console.ReadLine();
            luku1 = int.Parse(line);

            Console.WriteLine("Anna luku 2: ");
            line = Console.ReadLine();
            luku2 = int.Parse(line);

            Console.WriteLine("Anna luku 3: ");
            line = Console.ReadLine();
            luku3 = int.Parse(line);

            if (luku1>luku2 && luku2>luku3 || luku1>luku3 && luku3>luku2)
                Console.WriteLine("Syöttämäsi luku: " +luku1+ " on suurin");
            if (luku2 > luku1 && luku1 > luku3 || luku2 > luku3 && luku3 > luku1)
                Console.WriteLine("Syöttämäsi luku: " + luku2 + " on suurin");
            if (luku3 > luku2 && luku2 > luku1 || luku3 > luku2 && luku1 > luku2)
                Console.WriteLine("Syöttämäsi luku: " + luku3 + " on suurin");

        }
    }
}
