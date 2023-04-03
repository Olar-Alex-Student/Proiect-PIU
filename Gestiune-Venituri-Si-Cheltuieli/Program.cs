using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using static System.Net.Mime.MediaTypeNames;

namespace Gestiune_Venituri_Si_Cheltuieli
{
    internal class Program
    {
 
        static void Main(string[] args)
        {
            const string fisier = "D:\\DOWN\\Proiect - PIU\\Gestiune - Venituri - Si - Cheltuieli\\TextFile1.txt";

            Balanta balanta = new Balanta();

            string optiune;

            do 
            {
                Console.WriteLine("A. Afisati Suma Cont");
                Console.WriteLine("V. Adaugati Venit");
                Console.WriteLine("C. Adaugati Cheltuieli");
                Console.WriteLine("S. Salveaza suma din cont in fisier");
                Console.WriteLine("F. Vizualizeaza suma din cont salvata in fisier");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("Alegeti o optiune");

                optiune = Console.ReadLine();

                switch (optiune.ToUpper())
                {
                    case "A":
                        string cont = balanta.retBalantaString();
                        Console.WriteLine("Balanta ta este: {0}", cont);
                        break;
                    case "V":
                        Console.WriteLine("Scrie val pt. a adauga la venit.");
                        string _add = Console.ReadLine();
                        balanta.addBalanta(_add);
                        break;
                    case "C":
                        Console.WriteLine("Scrie val pt. a scadea din venit.");
                        string _sub = Console.ReadLine();
                        balanta.subBalanta(_sub);
                        break;
                    case "S":
                        balanta.introducereFisier(fisier, balanta.retBalantaString());
                        break;
                    case "F":
                        balanta.extragereFisier(fisier);
                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
            }
            while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }
    }
}
