using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cont_Utilizator
{
    public class Cont
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        private const bool SUCCES = true;
        public const int SUMA_MINIMA = 1;
        public const int SUMA_MAXIMA = 99999999;

        private const int ID = 0;
        private const int TIP = 1;
        private const int SUMAINTRODUSA = 2;
        private const int DETALII = 3;
        private const int SUMACONT = 4;

        public int Id { get; set; }
        public string Tip { get; set; }
        public int SumaIntrodusa { get; set; }
        public string Detalii { get; set; }
        public int SumaCont { get; set; }

        /*
        public ArrayList Detalii { get; set; } 

        public enum Detalii
        {
            Datorie,
            Salar,
            Tips,
            Pranz,
            Cina,
            MicDejun,
            Haine,
        }
        */

        public Cont()
        {
            SumaCont = 0;
        }

        public Cont(int Id, int SumaCont, int sumacheltuieli, string data)
        {
            this.Id = Id;
            this.SumaCont = SumaCont;
        }

        public Cont(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            Id = Convert.ToInt32(dateFisier[ID]);
            Tip = dateFisier[TIP];
            SumaIntrodusa = Convert.ToInt32(dateFisier[SUMAINTRODUSA]);
            Detalii = dateFisier[DETALII];
            SumaCont = Convert.ToInt32(dateFisier[SUMACONT]);

        }
        public string Info()
        {
            string info = string.Format("Suma Cont: {0}",
                SumaCont.ToString());

            return info;
        }
        public string InfoLast()
        {
            string info = string.Format("Tip: {0}, Suma Introdusa: {1}, Detalii: {2}, Suma Cont: {3}",
                (Tip ?? "Necunoscut"),
                SumaIntrodusa.ToString(),
                (Detalii ?? "Necunoscut"),
                SumaCont.ToString());

            return info;
        }

        public string ConversieLaSir_PentruFisier()
        {

            string obiectContPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}",
                SEPARATOR_PRINCIPAL_FISIER,
                Id.ToString(),
                (Tip ?? "Necunoscut"),
                SumaIntrodusa.ToString(),
                (Detalii ?? "Necunoscut"),
                SumaCont.ToString());

            return obiectContPentruFisier;
        }

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
