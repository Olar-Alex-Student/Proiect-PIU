using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cont_Utilizator
{
    public class Tranzactie
    {
        //constante
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        public const int SUMA_MINIMA = 1;
        public const int SUMA_MAXIMA = 999999999;

        private const int ID_TRANZACTIE = 0;
        private const int SUMA_INTRODUSA = 1;
        private const int TIP = 2;
        private const int DETALII = 3;

        //proprietati auto-implemented
        public int Id { get; set; }
        public int SumaIntrodusa { get; set; }

        public enum Tip
        {
            Venit,
            Cheltuieli
        }

        public string TipTranzactie { get; set; }

        public string Detalii { get; set; }

        //contructor implicit
        public Tranzactie()
        {
            SumaIntrodusa = 0;
        }

        //constructor cu parametri
        public Tranzactie( int sumaIntrodusa)
        {
            this.SumaIntrodusa = sumaIntrodusa;
        }

        //constructor cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text
        public Tranzactie(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            Id = int.Parse(dateFisier[ID_TRANZACTIE]);
            SumaIntrodusa = int.Parse(dateFisier[SUMA_INTRODUSA]);
            foreach(string tip in Enum.GetNames(typeof(Tip)))
            {
                if (dateFisier[TIP] == tip)
                    TipTranzactie = tip;
            }
            Detalii = dateFisier[DETALII];

        }

        //inforamtii despre Tranzactie
        public string Info()
        {
            string info = string.Format("Id: {0}, Suma: {1}, Tip: {2}, Detalii: {3}",
                Id.ToString(),
                SumaIntrodusa.ToString(),
                TipTranzactie,
                Detalii
                );

            return info;
        }

        //transformarea valorilor intr-un sirt pt. fisier text
        public string ConversieLaSir_PentruFisier()
        {
            string obiectContPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}",
                SEPARATOR_PRINCIPAL_FISIER,
                Id.ToString(),
                SumaIntrodusa.ToString(),
                TipTranzactie,
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
