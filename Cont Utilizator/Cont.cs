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
        private const int IDCONT = 2;

        float[] suma;

        private float sumaCont;
        private string numeCont;
        private int idCont;

        public int IdCont
        { 
            get { return idCont; }
            set { idCont = value; }
        }
        public float SumaCont 
        { 
          get { return sumaCont; }
          set { sumaCont = value; }
        }
        public string NumeCont 
        {
          get { return numeCont; }
          set { numeCont = value; }
        }

        public Cont()
        {
            sumaCont = 0.0f;
            numeCont = null;
            idCont = 0;
        }

        public Cont(float sumaCont, string numeCont, int idCont)
        {
            this.sumaCont = sumaCont;
            this.numeCont = numeCont;
            this.idCont = idCont;
        }

        public void AddSumaCont()
        {
            Console.WriteLine("Scrie valoarea pe care vrei sa o adaugi in cont:");
            string text = Console.ReadLine();
            float add = float.Parse(text);
            SumaCont += add;
        }

        public void SubSumaCont()
        {
            Console.WriteLine("Scrie valoarea pe care vrei sa o cheltui din cont:");
            string text = Console.ReadLine();
            float sub = float.Parse(text);
            SumaCont -= sub;
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
            foreach (string sum in vectorSumaDupaSplit)
            {
                bool rezultatConversie = float.TryParse(sum, out suma[nrSuma]);
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
            string info = string.Format("Id Cont {0}, Nume Cont {1}, Suma Cont {2}",
                idCont,
                (numeCont ?? " NECUNOSCUT "),
                sumaCont.ToString());

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
