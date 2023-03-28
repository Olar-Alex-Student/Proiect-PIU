using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestiune_Venituri_Si_Cheltuieli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Balanta balanta = new Balanta(100);
            float myBalanta = balanta.retBalanta();
            Console.WriteLine("Balanta mea este {0}.",myBalanta);
            Console.ReadKey();
        }
    }
}
