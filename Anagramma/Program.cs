using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagramma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OsAnya tesztAnya = new OsAnya('a');
            Gyerek tesztGyerekB = new Gyerek(tesztAnya, 'b');
            Gyerek tesztGyerekC = new Gyerek(tesztGyerekB, 'c');

            Console.WriteLine(tesztGyerekC.ToString());
        }
    }
}
