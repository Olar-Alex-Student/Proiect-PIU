using Cont_Utilizator;
using Nivel_Stocare_Date;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace Gestiune_Venituri_Si_Cheltuieli
{
    internal class Program
    {
 
        static void Main(string[] args)
        {
            Cont cont = new Cont();
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            AdministrareConturi_FisierText adminConturi = new AdministrareConturi_FisierText(caleCompletaFisier);

            int nrModificare = 0;

            //adminConturi.GetModificari();

            string optiune;
            do
            {
                Console.WriteLine("+. Adauga Venit");
                Console.WriteLine("-. Adauga Cheltuieli");
                Console.WriteLine("A. Afiseaza Detalii Cont");
                Console.WriteLine("L. Afiseaza Ultima Modificare");
                Console.WriteLine("S. Salveaza Schimbari");
                Console.WriteLine("F. Afiseaza Gestiune");
                Console.WriteLine("C. Cautare Gestiune");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "+":
                        Venit(cont);
                        break;
                    case "-":
                        Cheltuieli(cont);
                        break;
                    case "A":
                        AfisareCont(cont);
                        break;
                    case "L":
                        Console.WriteLine(cont.InfoLast());
                        break;
                    case "S":
                        int idModificare = nrModificare + 1;
                        cont.Id = idModificare;
                        //adaugare cont in fisier
                        adminConturi.AddCont(cont);

                        nrModificare = nrModificare + 1;
                        break;
                    case "F":
                        List<Cont> modificari = adminConturi.GetModificari();
                        AfisareModificari(modificari);
                        break;
                    case "C":
                        return;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }
        public static void AfisareModificare(Cont cont)
        {
            string info = string.Format("Id: {0} Tip: {1}, Suma Introdusa: {2}, Detalii: {3}, Suma Cont: {4}",
                cont.Id.ToString(),
                (cont.Tip ?? "Necunoscut"),
                cont.SumaIntrodusa.ToString(),
                (cont.Detalii ?? "Necunoscut"),
                cont.SumaCont.ToString());

            Console.WriteLine(info);
        }
        public static void AfisareModificari(List<Cont> modificari)
        {
            for (int contor = 0; contor < modificari.Count; contor++)
            {
                AfisareModificare(modificari[contor]);
            }
        }
        public static void AfisareCont(Cont cont)
        {
            string infoCont = cont.Info();

            Console.WriteLine(infoCont);
        }

        public static void Venit(Cont cont)
        {
            Console.WriteLine("Introduceti Suma:");
            string sumaString = Console.ReadLine();
            int sumaInt = int.Parse(sumaString);
            if(cont.ValideazaSuma(sumaInt) != true )
            {
                Console.WriteLine("Suma Incorecta!");
                return;
            }
            else
            {
                cont.SumaIntrodusa = sumaInt;
                cont.SumaCont += sumaInt;
                cont.Tip = "Venit";
                Console.WriteLine("Detalii Suma:");
                string detalii = Console.ReadLine();
                cont.Detalii = detalii;
            }
            
        }

        public static void Cheltuieli(Cont cont)
        {
            Console.WriteLine("Introduceti Suma:");
            string sumaString = Console.ReadLine();
            int sumaInt = int.Parse(sumaString);
            if (cont.ValideazaSuma(sumaInt) != true)
            {
                Console.WriteLine("Suma Incorecta!");
                return;
            }
            else
            {
                cont.SumaIntrodusa = sumaInt;
                cont.SumaCont -= sumaInt;
                cont.Tip = "Cheltuieli";
                Console.WriteLine("Detalii Suma:");
                string detalii = Console.ReadLine();
                cont.Detalii = detalii;
            }
        }
    }
}
