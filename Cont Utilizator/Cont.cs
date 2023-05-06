using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cont_Utilizator
{
    public class Cont
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        private const bool SUCCES = true;
        public const int SUMA_MINIMA = 0;
        public const int SUMA_MAXIMA = 99999999;

        private const int IDCONT = 0;
        private const int NUMECONT = 1;
        private const int SUMECONT = 2;

        int[] sume;

        public int IdCont { get; set; }
        public string NumeCont { get; set; }

        public int[] GetSume()
        {
            return (int[])sume.Clone();
        }

        public Cont()
        {
            NumeCont = string.Empty;
        }

        public Cont(int idCont, string numeCont)
        {
            this.IdCont = idCont;
            this.NumeCont = numeCont;
        }

        public Cont(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            IdCont = Convert.ToInt32(dateFisier[IDCONT]);
            NumeCont = dateFisier[NUMECONT];
            SetSume(dateFisier[SUMECONT], SEPARATOR_SECUNDAR_FISIER);
        }

        public void AdaugaLaSuma(int _add, int index)
        {
            sume[index - 1] += _add;
        }

        public void ScadeDeLaSuma(int _sub, int index)
        {
            sume[index - 1] -= _sub;
        }

        public string Info()
        {
            string info = string.Format("Id Cont:{0} Nume Cont:{1}",
                IdCont.ToString(),
                (NumeCont ?? " NECUNOSCUT "));

            return info;
        }

        public string ConversieLaSir_PentruFisier()
        {
            string sSume = string.Empty;
            if (sume != null)
            {
                sSume = string.Join(SEPARATOR_SECUNDAR_FISIER.ToString(), sume);
            }

            string obiectContPentruFisier = string.Format("{1}{0}{2}{0}{3}",
                SEPARATOR_PRINCIPAL_FISIER,
                IdCont.ToString(),
                (NumeCont ?? " NECUNOSCUT "),
                sSume);

            return obiectContPentruFisier;
        }

        public void SetSume(string sirSume, char delimitator = ' ')
        {
            string[] vectorSumeDupaSplit = sirSume.Split(delimitator);
            sume = new int[vectorSumeDupaSplit.Length];

            int nrSume = 0;
            foreach (string nota in vectorSumeDupaSplit)
            {
                bool rezultatConversie = Int32.TryParse(nota, out sume[nrSume]);
                if (rezultatConversie == SUCCES && ValideazaSuma(sume[nrSume]) == SUCCES)
                {
                    nrSume++;
                }
            }

            Array.Resize(ref sume, nrSume);
        }

        public void SetSume(int[] _sume)
        {
            sume = new int[_sume.Length];
            _sume.CopyTo(sume, 0);
        }

        private bool ValideazaSuma(int suma)
        {
            if (suma >= SUMA_MINIMA && suma <= SUMA_MAXIMA)
            {
                return true;
            }

            return false;
        }
    }
}
