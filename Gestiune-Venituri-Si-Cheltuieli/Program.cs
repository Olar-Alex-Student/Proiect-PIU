﻿using Cont_Utilizator;

using Nivel_Stocare_Date;

using System;
using System.Collections.Generic;
using System.Configuration;
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
            Cont cont = new Cont();
            string NumeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            AdministrareVenit_FisierText adminConturi = new AdministrareVenit_FisierText(NumeFisier);
            int nrConturi = 0;
            adminConturi.GetConturi(out nrConturi);

            string optiune;

            do 
            {
                Console.WriteLine("I. Introdu informatii cont");
                Console.WriteLine("A. Afisare ultimul cont introdus");
                Console.WriteLine("F. Afisati conturi din fisier");
                Console.WriteLine("S. Salveaza cont in fisier");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("Alegeti o optiune");

                optiune = Console.ReadLine();

                switch (optiune.ToUpper())
                {
                    case "I":
                        cont = CitireStudentTastatura();
                        break;
                    case "A":
                        AfisareCont(cont);
                        break;
                    case "S":
                        adminConturi.AddCont(cont);

                        nrConturi = nrConturi + 1;
                        break;
                    case "F":
                        Cont[] conturi = adminConturi.GetConturi(out nrConturi);
                        AfisareConturi(conturi, nrConturi);
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

        public static Cont CitireStudentTastatura()
        {
            Console.WriteLine("Introduceti numele la cont");
            string nume = Console.ReadLine();

            Cont cont = new Cont(0, nume);

            Console.WriteLine("Introduceti suma din cont");
            string suma = Console.ReadLine();
            cont.SetSumaCont(suma);

            return cont;
        }

        public static void AfisareCont(Cont cont)
        {
            string infoCont = string.Format("Contul cu suma {0} are numele: {1}",
                    cont.GetNumeCont() ?? " NECUNOSCUT ",
                    string.Join(",", cont.GetSumaCont()));

            Console.WriteLine(infoCont);
        }

        public static void AfisareConturi(Cont[] conturi, int nrConturi)
        {
            Console.WriteLine("Studentii sunt:");
            for (int contor = 0; contor < nrConturi; contor++)
            {
                AfisareCont(conturi[contor]);
            }
        }
    }
}
