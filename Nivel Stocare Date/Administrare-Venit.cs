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
    public class AdministrareCont_FisierText : IStocareData
    {
        private const int ID_PRIMA_MODIFICARE = 1;
        private const int INCREMENT = 1;

        private string numeFisier;

        public AdministrareCont_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddModificare(Cont cont)
        {
            cont.IdCont = GetId();

            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(cont.ConversieLaSir_PentruFisier());
            }
        }

        public List<Cont> GetGestiune()
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

        public Cont GetModifiacre(int sumaIntrodusa)
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
                    if (cont.SumaIntrodusa == sumaIntrodusa)
                        return cont;
                }
            }

            return null;
        }

        public Cont GetModificare(int idCont)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Cont cont= new Cont(linieFisier);
                    if (cont.IdCont == idCont)
                        return cont;
                }
            }

            return null;
        }

        public bool UpdateModificare(Cont modificareActualizata)
        {
            List<Cont> modificari = GetGestiune();
            bool actualizareCuSucces = false;

            //instructiunea 'using' va apela la final swFisierText.Close();
            //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, false))
            {
                foreach (Cont cont in modificari)
                {
                    Cont modificarePentruScrisInFisier = cont;
                    //informatiile despre studentul actualizat vor fi preluate din parametrul "studentActualizat"
                    if (cont.IdCont == modificareActualizata.IdCont)
                    {
                        modificarePentruScrisInFisier = modificareActualizata;
                    }
                    streamWriterFisierText.WriteLine(modificarePentruScrisInFisier.ConversieLaSir_PentruFisier());
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
                    IdCont = cont.IdCont + INCREMENT;
                }
            }

            return IdCont;
        }
    }
}
