using Cont_Utilizator;
using Nivel_Stocare_Date;
using System;
using System.Configuration;
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
            int nrConturi = 0;
            adminConturi.GetConturi(out nrConturi);

            string optiune;
            do
            {
                Console.WriteLine("I. Introducere informatii cont");
                Console.WriteLine("A. Afisarea ultimului cont introdus");
                Console.WriteLine("F. Afisare cont din fisier");
                Console.WriteLine("S. Salvare cont in fisier");
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
                    case "F":
                        Cont[] conturi = adminConturi.GetConturi(out nrConturi);
                        AfisareStudenti(conturi, nrConturi);

                        break;
                    case "S":
                        int idCont = nrConturi + 1;
                        cont.IdCont = idCont;
                        //adaugare student in fisier
                        adminConturi.AddCont(cont);

                        nrConturi = nrConturi + 1;

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

        public static void AfisareCont(Cont cont)
        {
            string infoCont = string.Format("Contul cu id-ul #{0} are numele: {1} si sumele: {2}",
                    cont.IdCont,
                    cont.NumeCont ?? " NECUNOSCUT ",
                    string.Join(",", cont.GetSume()));

            Console.WriteLine(infoCont);
        }

        public static void AfisareStudenti(Cont[] conturi, int nrConturi)
        {
            Console.WriteLine("Conturile sunt:");
            for (int contor = 0; contor < nrConturi; contor++)
            {
                AfisareCont(conturi[contor]);
            }
        }

        public static Cont CitireStudentTastatura()
        {
            Console.WriteLine("Introduceti numele contului");
            string nume = Console.ReadLine();

            Cont cont = new Cont(0, nume);

            Console.WriteLine("Introduceti sumele");
            string sume = Console.ReadLine();
            cont.SetSume(sume);

            return cont;
        }
    }
}
