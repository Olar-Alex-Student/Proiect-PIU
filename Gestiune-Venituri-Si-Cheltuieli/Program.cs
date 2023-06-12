using Cont_Utilizator;
using Nivel_Stocare_Date;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.IO;

using static Cont_Utilizator.Tranzactie;

namespace Gestiune_Venituri_Si_Cheltuieli
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            // setare locatie fisier in directorul corespunzator solutiei
            // astfel incat datele din fisier sa poata fi utilizate si de alte proiecte
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            AdministrareTranzactie_FisierText admin = new AdministrareTranzactie_FisierText(caleCompletaFisier);

            Cont cont = new Cont();

            List<Tranzactie> tranzactii = new List<Tranzactie>();

            tranzactii = admin.GetTranzactii();

            string optiune;

            do
            {
                Console.WriteLine("C. Afisare Suma Cont");
                Console.WriteLine("+. Adauga Venit");
                Console.WriteLine("-. Adauga Cheltuieli");
                Console.WriteLine("F. Afisare Gestiune Din Fisier");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("Alegeti o optiune");

                optiune = Console.ReadLine();

                switch (optiune.ToUpper())
                {
                    case "C":
                        SetSuma(tranzactii, cont);
                        Console.WriteLine(cont.Info());

                        break;
                    case "+":
                        AdaugaVenit(cont, admin, tranzactii);

                        break;
                    case "-":
                        AdaugaCheltuieli(cont, admin, tranzactii);

                        break;
                    case "F":
                        AfisareTranzactiiFisier(tranzactii);

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
        
        //adaugare venit la suma din cont
        public static void AdaugaVenit(Cont cont, AdministrareTranzactie_FisierText admin, List<Tranzactie> tranzactii)
        {
            Tranzactie tranzactie = new Tranzactie();

            Console.WriteLine("Introduceti Suma:");

            string sumaString = Console.ReadLine();
            int sumaInt = int.Parse(sumaString);

            if (tranzactie.ValideazaSuma(sumaInt) != true)
            {
                Console.WriteLine("Suma Incorecta!");
                return;
            }
            else
            {
                tranzactie.Id = admin.GetId();

                tranzactie.SumaIntrodusa = sumaInt;

                cont.Venit(sumaInt);

                tranzactie.TipTranzactie = Tip.Cheltuieli.ToString();

                Console.WriteLine("Detalii Suma:");

                string detalii = Console.ReadLine();

                tranzactie.Detalii = detalii;

                tranzactii.Add(tranzactie);

                admin.AddTranzactie(tranzactie);
            }
        }

        //adaugare cheltuieli la suma din cont
        public static void AdaugaCheltuieli(Cont cont, AdministrareTranzactie_FisierText admin, List<Tranzactie> tranzactii)
        {
            Tranzactie tranzactie = new Tranzactie();

            Console.WriteLine("Introduceti Suma:");

            string sumaString = Console.ReadLine();
            int sumaInt = int.Parse(sumaString);

            if (tranzactie.ValideazaSuma(sumaInt) != true)
            {
                Console.WriteLine("Suma Incorecta!");
                return;
            }
            else
            {
                tranzactie.Id = admin.GetId();

                tranzactie.SumaIntrodusa = sumaInt;

                cont.Cheltuiala(sumaInt);

                tranzactie.TipTranzactie = Tip.Venit.ToString();

                Console.WriteLine("Detalii Suma:");

                string detalii = Console.ReadLine();

                tranzactie.Detalii = detalii;

                tranzactii.Add(tranzactie);

                admin.AddTranzactie(tranzactie);
            }
        }
        
        //afisare tranzactii din fifier
        public static void AfisareTranzactiiFisier(List<Tranzactie> tranzactii)
        {
            Console.WriteLine("Tranzactiile sunt:");

            foreach(Tranzactie tranzactie in tranzactii)
            {
                Console.WriteLine(tranzactie.Info());
            }
        }

        public static void SetSuma(List<Tranzactie> tranzactii, Cont cont)
        {
            cont.Suma = 0;
            foreach (Tranzactie tranzactie in tranzactii)
            {
                if (tranzactie.TipTranzactie == "Venit")
                {
                    cont.Venit(tranzactie.SumaIntrodusa);
                }
                if (tranzactie.TipTranzactie == "Cheltuieli")
                {
                    cont.Cheltuiala(tranzactie.SumaIntrodusa);
                }
            }
        }
    }
}
