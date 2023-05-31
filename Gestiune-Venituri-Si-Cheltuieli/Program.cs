﻿using Cont_Utilizator;
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
            // setare locatie fisier in directorul corespunzator solutiei
            // astfel incat datele din fisier sa poata fi utilizate si de alte proiecte
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            AdministrareCont_FisierText adminModificari = new AdministrareCont_FisierText(caleCompletaFisier);
            int nrModificari = 0;
            // acest apel ajuta la obtinerea numarului de studenti inca de la inceputul executiei
            // astfel incat o eventuala adaugare sa atribuie un IdStudent corect noului student
            adminModificari.GetGestiune();

            string optiune;
            do
            {
                Console.WriteLine("+. Adauga Venit");
                Console.WriteLine("-. Adauga Cheltuieli");
                Console.WriteLine("A. Afisare Ultima Modificare");
                Console.WriteLine("F. Afisare Gestiune Din Fisier");
                Console.WriteLine("S. Salvare Modificare In Fisier");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "+":
                        AdaugaVenit(cont);

                        break;
                    case "-":
                        AdaugaCheltuieli(cont);

                        break;
                    case "A":
                        AfisareCont(cont);

                        break;
                    case "F":
                        List<Cont> modificari = adminModificari.GetGestiune();
                        AfisareModificari(modificari);

                        break;
                    case "S":
                        int idCont = nrModificari + 1;
                        cont.IdCont = idCont;
                        //adaugare student in fisier
                        adminModificari.AddModificare(cont);

                        nrModificari = nrModificari + 1;

                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }

        public static void AdaugaVenit(Cont cont)
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
                cont.SumaCont += sumaInt;
                cont.Tip = EnumVenitCheltuieli.Venit;
                Console.WriteLine("Detalii Suma:");
                string detalii = Console.ReadLine();
                cont.Detalii = detalii;
            }
        }
        public static void AdaugaCheltuieli(Cont cont)
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
                cont.Tip = EnumVenitCheltuieli.Cheltuieli;
                Console.WriteLine("Detalii Suma:");
                string detalii = Console.ReadLine();
                cont.Detalii = detalii;
            }
        }
        public static void AfisareCont(Cont cont)
        {
            string info = string.Format("Id: {0}, Suma Cont: {4}, Tip: {1}, Suma Introdusa: {2}, Detalii: {3}",
                cont.IdCont.ToString(),
                cont.Tip,
                cont.SumaIntrodusa.ToString(),
                (cont.Detalii ?? "Necunoscut"),
                cont.SumaCont.ToString());

            Console.WriteLine(info);
        }

        public static void AfisareModificari(List<Cont> modificari)
        {
            Console.WriteLine("Modificarile sunt:");
            for (int contor = 0; contor < modificari.Count; contor++)
            {
                AfisareCont(modificari[contor]);
            }
        }
    }
}
