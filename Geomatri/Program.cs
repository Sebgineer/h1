using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomatri
{
    class Program
    {
        static void Main(string[] args)
        {
            Kvadrat kage = new Kvadrat(23);

            Console.WriteLine(kage.perimeter());
            Console.WriteLine(kage.Areal());
            Console.ReadKey();
        }
    }
}
