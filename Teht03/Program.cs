using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3;
            Console.Write("Syötä kolme lukua: ");
            string line = Console.ReadLine();
            luku1 = int.Parse(line);
            line = Console.ReadLine();
            luku2 = int.Parse(line);
            line = Console.ReadLine();
            luku3 = int.Parse(line);
            int summa = luku1 + luku2 + luku3;
            Console.WriteLine("Lukujen summa on " + summa);
            int karvo = (luku1 + luku2 + luku3) / 3;
            Console.WriteLine("Lukujen keskiarvo on " + karvo);

        }
    }
}
