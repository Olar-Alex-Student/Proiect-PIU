using Cont_Utilizator;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel_Stocare_Date
{
    public class AdministrareConturi_FisierText : IStocareData
    {
        private const int ID_PRIMA_MODIFICARE = 1;
        private const int INCREMENT = 1;

        private string numeFisier;

        public AdministrareConturi_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddCont(Cont cont)
        {
            cont.Id = GetId();

            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(cont.ConversieLaSir_PentruFisier());
            }
        }

        public List<Cont> GetModificari()
        {
            List<Cont> modificari = new List<Cont>();

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Cont cont = new Cont(linieFisier);
                    modificari.Add(cont);
                }
            }

            return modificari;
        }

        public Cont GetCont(string tip)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Cont cont = new Cont(linieFisier);
                    if (cont.Tip.Equals(tip))
                        return cont;
                }
            }

            return null;
        }

        public Cont GetCont(int id)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Cont cont = new Cont(linieFisier);
                    if (cont.Id == id)
                        return cont;
                }
            }

            return null;
        }

        public bool UpdateCont(Cont contActualizat)
        {
            List<Cont> modificari = GetModificari();
            bool actualizareCuSucces = false;

            //instructiunea 'using' va apela la final swFisierText.Close();
            //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, false))
            {
                foreach (Cont cont in modificari)
                {
                    Cont contPentruScrisInFisier = cont;
                    //informatiile despre studentul actualizat vor fi preluate din parametrul "studentActualizat"
                    if (cont.Id == contActualizat.Id)
                    {
                        contPentruScrisInFisier = contActualizat;
                    }
                    streamWriterFisierText.WriteLine(contPentruScrisInFisier.ConversieLaSir_PentruFisier());
                }
                actualizareCuSucces = true;
            }

            return actualizareCuSucces;
        }

        private int GetId()
        {
            int IdCont = ID_PRIMA_MODIFICARE;

            // instructiunea 'using' va apela sr.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Cont cont = new Cont(linieFisier);
                    IdCont = cont.Id + INCREMENT;
                }
            }

            return IdCont;
        }
    }
}
