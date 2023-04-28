using Cont_Utilizator;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel_Stocare_Date
{
    public class AdministrareVenit_FisierText
    {
        private const int NR_MAX_CONTURI = 50;
        private string NumeFisier;

        public AdministrareVenit_FisierText(string NumeFisier)
        {
            this.NumeFisier = NumeFisier;
            Stream streamFisierText = File.Open(NumeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddCont(Cont cont)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(NumeFisier, true))
            {
                streamWriterFisierText.WriteLine(cont.ConversieLaSir_PentruFisier());
            }
        }

        public Cont[] GetConturi(out int nrConturi)
        {
            Cont[] conturi = new Cont[NR_MAX_CONTURI];

            using (StreamReader streamReader = new StreamReader(NumeFisier))
            {
                string linieFisier;
                nrConturi = 0;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    conturi[nrConturi++] = new Cont(linieFisier);
                }
            }

            return conturi;
        }  
    }
}
