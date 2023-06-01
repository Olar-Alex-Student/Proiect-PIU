using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cont_Utilizator
{
    public enum EnumVenitCheltuieli
    {
        Cheltuieli  = 0,
        Venit = 1,
        Necunoscut = 2
    }

    [Serializable]
    public class Cont
    {
        //constante
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        private const bool SUCCES = true;
        public const int SUMA_MINIMA = 1;
        public const int SUMA_MAXIMA = 999999999;

        private const int ID = 0;
        private const int SUMA_CONT = 1;
        private const int TIP = 2;
        private const int SUMA_INTRODUSA = 3;
        private const int DETALII = 4;

        //proprietati auto-implemented
        public int IdCont { get; set; }
        public int SumaCont { get; set; }
        public EnumVenitCheltuieli Tip { get; set; }
        public int SumaIntrodusa { get; set; }
        public string Detalii { get; set; }

        //contructor implicit
        public Cont()
        {
            SumaCont = 0;
        }

        //constructor cu parametri
        public Cont(int idCont, int sumaCont)
        {
            this.IdCont = idCont;
            this.SumaCont = sumaCont;
        }

        //constructor cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text
        public Cont(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            IdCont = int.Parse(dateFisier[ID]);
            SumaCont = int.Parse(dateFisier[SUMA_CONT]);
            Tip = (EnumVenitCheltuieli)Enum.Parse(typeof(EnumVenitCheltuieli), dateFisier[TIP]);
            SumaIntrodusa = int.Parse(dateFisier[SUMA_INTRODUSA]);

            Detalii = dateFisier[DETALII];

        }

        //inforamtii despre cont minime
        public string Info()
        {
            string info = string.Format("Id: {0} Suma: {1}",
                IdCont.ToString(),
                SumaCont.ToString());

            return info;
        }

        //transformarea valorilor intr-un sirt pt. fisier text
        public string ConversieLaSir_PentruFisier()
        {
            string obiectContPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}",
                SEPARATOR_PRINCIPAL_FISIER,
                IdCont.ToString(),
                SumaCont.ToString(),
                (Tip != EnumVenitCheltuieli.Necunoscut),
                SumaIntrodusa.ToString(),
                (Detalii ?? "Necunoscut"));

            return obiectContPentruFisier;
        }
        
        //transformarea datelor in tip string
        public override string ToString()
        {
            return ConversieLaSir_PentruFisier();
        }

        //Validarea unei sume
        public bool ValideazaSuma(int suma)
        {
            if (suma >= SUMA_MINIMA && suma <= SUMA_MAXIMA)
            {
                return true;
            }

            return false;
        }
    }
}
