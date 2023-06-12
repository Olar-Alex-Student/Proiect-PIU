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
        //constante
        public const int SUMA_MINIMA = 1;
        public const int SUMA_MAXIMA = 999999999;

        //proprietati auto-implemented
        public int Suma { get; set; }

        //contructor implicit
        public Cont()
        {
            Suma = 0;
        }

        //constructor cu parametri
        public Cont(int sumaCont)
        {
            this.Suma = sumaCont;
        }

        //inforamtii despre cont minime
        public string Info()
        {
            string info = string.Format("Suma Cont: {0}",
                Suma.ToString());

            return info;
        }

        public void Venit(int venit)
        {
            Suma += venit;
        }

        public void Cheltuiala(int cheltuiala)
        {
            Suma -= cheltuiala;
        }
    }
}
