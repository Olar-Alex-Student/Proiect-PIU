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
                Console.WriteLine("+. Adauga la o suma din cont curent");
                Console.WriteLine("-. Scade de la o suma din cont curent");
                Console.WriteLine("+F. Adauga la o suma din cont curent");
                Console.WriteLine("-F. Scade de la o suma din cont curent");
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
                    case "+":
                        AdaugaCurent(cont);
                        break;
                    case "-":
                        ScadeCurent(cont);
                        break;
                    case "+F":
                        Cont[] conturi1 = adminConturi.GetConturi(out nrConturi);
                        AdaugaFisier(conturi1);
                        break;
                    case "-F":
                        Cont[] conturi2 = adminConturi.GetConturi(out nrConturi);
                        ScadeFisier(conturi2);
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

        public static void AdaugaCurent(Cont cont)
        {
            Console.WriteLine("Scrie Suma pe care vrei sa o adaugi:");
            string add = Console.ReadLine();
            int _add = Int32.Parse(add);

            Console.WriteLine("Scrie Contul la care vrei sa se adauge:");
            string index = Console.ReadLine();
            int _index = Int32.Parse(index);

            cont.AdaugaLaSuma(_add, _index);


        }

        public static void ScadeCurent(Cont cont)
        {
            Console.WriteLine("Scrie Suma pe care vrei sa o scazi:");
            string sub = Console.ReadLine();
            int _sub = Int32.Parse(sub);

            Console.WriteLine("Scrie Contul la care vrei sa se scada:");
            string index = Console.ReadLine();
            int _index = Int32.Parse(index);

            cont.ScadeDeLaSuma(_sub, _index);
        }

        public static void AdaugaFisier(Cont[] conturi)
        {
            Console.WriteLine("Scrie ID-ul contului:");
            string id = Console.ReadLine();
            int _id = Int32.Parse(id);

            Console.WriteLine("Scrie Suma pe care vrei sa o adaugi:");
            string add = Console.ReadLine();
            int _add = Int32.Parse(add);

            Console.WriteLine("Scrie nr. Sumei la care vrei sa se adauge:");
            string index = Console.ReadLine();
            int _index = Int32.Parse(index);

            conturi[_id-1].AdaugaLaSuma(_add, _index);


        }
        public static void ScadeFisier(Cont[] conturi)
        {
            Console.WriteLine("Scrie ID-ul contului:");
            string id = Console.ReadLine();
            int _id = Int32.Parse(id);

            Console.WriteLine("Scrie Suma pe care vrei sa o scazi:");
            string sub = Console.ReadLine();
            int _sub = Int32.Parse(sub);

            Console.WriteLine("Scrie nr. Sumei la care vrei sa se scada:");
            string index = Console.ReadLine();
            int _index = Int32.Parse(index);

            conturi[_id].ScadeDeLaSuma(_sub, _index);
        }
    }
}
