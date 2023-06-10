using Cont_Utilizator;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Nivel_Stocare_Date
{
    public class AdministrareTranzactie_FisierText : IStocareData
    {
        private const int ID_PRIMA_MODIFICARE = 1;
        private const int INCREMENT = 1;

        private string numeFisier;

        public AdministrareTranzactie_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddTranzactie(Tranzactie tranzactie)
        {
            tranzactie.Id = GetId();

            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(tranzactie.ConversieLaSir_PentruFisier());
            }
        }

        public List<Tranzactie> GetTranzactii()
        {
            List<Tranzactie> tranzactii = new List<Tranzactie>();

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Tranzactie
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Tranzactie tranzactie = new Tranzactie(linieFisier);
                    tranzactii.Add(tranzactie);
                }
            }

            return tranzactii;
        }

        public Tranzactie GetTranzactieCuSuma(int sumaIntrodusa)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Tranzactie
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Tranzactie tranzactie = new Tranzactie(linieFisier);
                    if (tranzactie.SumaIntrodusa == sumaIntrodusa)
                        return tranzactie;
                }
            }

            return null;
        }

        public Tranzactie GetTranzactieCuId(int id)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Modificare
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Tranzactie tranzactie = new Tranzactie(linieFisier);
                    if (tranzactie.Id == id)
                        return tranzactie;
                }
            }
            return null;
        }

        public bool UpdateModificare(Tranzactie modificareActualizata)
        {
            List<Tranzactie> tranzactii = GetTranzactii();
            bool actualizareCuSucces = false;

            //instructiunea 'using' va apela la final swFisierText.Close();
            //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, false))
            {
                foreach (Tranzactie tranzactie in tranzactii)
                {
                    Tranzactie modificarePentruScrisInFisier = tranzactie;
                    //informatiile despre studentul actualizat vor fi preluate din parametrul "modificareActualizata"
                    if (tranzactie.Id == modificareActualizata.Id)
                    {
                        modificarePentruScrisInFisier = modificareActualizata;
                    }
                    streamWriterFisierText.WriteLine(modificarePentruScrisInFisier.ConversieLaSir_PentruFisier());
                }
                actualizareCuSucces = true;
            }

            return actualizareCuSucces;
        }

        public int GetId()
        {
            int Id = ID_PRIMA_MODIFICARE;

            // instructiunea 'using' va apela sr.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                //citeste cate o linie si creaza un obiect de tip Cont pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Tranzactie tranzactie = new Tranzactie(linieFisier);
                    Id = tranzactie.Id + INCREMENT;
                }
            }

            return Id;
        }
    }
}
