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
        public const float SUMA_MINIMA = -999999999;
        public const float SUMA_MAXIMA = 999999999;

        private const int SUMACONT = 0;
        private const int NUMECONT = 1;

        float[] suma;

        private float sumaCont { get; set; }
        private string numeCont { get; set; }

        public Cont()
        {
            sumaCont = 0.0f;
            numeCont = null;
        }

        public Cont(float sumaCont, string numeCont)
        {
            this.sumaCont = sumaCont;
            this.numeCont = numeCont;
        }

        public string GetNumeCont()
        {
            return numeCont;
        }

        public void SetNumeCont(string numeCont)
        {
            this.numeCont = numeCont;
        }

        public float GetSumaCont()
        {
            return sumaCont;
        }

        public void SetSumaCont(float sumaCont)
        {
            this.sumaCont = sumaCont;
        }

        public void AddSumaCont(float add)
        {
            this.sumaCont += add;
        }

        public void SubSumaCont(float sub)
        {
            this.sumaCont -= sub;
        }

        private bool ValideazaSuma(float suma)
        {
            if (suma >= SUMA_MINIMA && suma <= SUMA_MAXIMA)
            {
                return true;
            }

            return false;
        }

        public void SetSumaCont(string sirSuma, char delimitator = ' ')
        {
            string[] vectorSumaDupaSplit = sirSuma.Split(delimitator);
            suma = new float[vectorSumaDupaSplit.Length];

            int nrSuma = 0;
            foreach (string nota in vectorSumaDupaSplit)
            {
                bool rezultatConversie = float.TryParse(nota, out suma[nrSuma]);
                if (rezultatConversie == SUCCES && ValideazaSuma(suma[nrSuma]) == SUCCES)
                {
                    nrSuma++;
                }
            }

            Array.Resize(ref suma, nrSuma);
        }

        public Cont(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            numeCont = dateFisier[NUMECONT];
            SetSumaCont(dateFisier[SUMACONT], SEPARATOR_SECUNDAR_FISIER);
        }

        public string Info()
        {
            string info = string.Format("Suma Cont:{0} Nume Cont:{1}",
                sumaCont.ToString(),
                (numeCont ?? " NECUNOSCUT "));

            return info;
        }

        public string ConversieLaSir_PentruFisier()
        {
            string sSumaCont = string.Empty;
            if (sumaCont != 0.0f)
            {
                sSumaCont = string.Join(SEPARATOR_SECUNDAR_FISIER.ToString(), sumaCont);
            }

            string obiectStudentPentruFisier = string.Format("{1}{0}{2}",
                SEPARATOR_PRINCIPAL_FISIER,
                (numeCont ?? " NECUNOSCUT "),
                sSumaCont);

            return obiectStudentPentruFisier;
        }
    }
}
