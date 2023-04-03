using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestiune_Venituri_Si_Cheltuieli
{
    internal class Balanta
    {
        float suma;
        public Balanta()
        {
            suma = 0;
        }

        public Balanta(string _sum)
        {
            float sum = float.Parse(_sum);
            suma = sum;
        }

        public void addBalanta(string _add)
        {
            float add = float.Parse(_add);
            suma += add;
        }

        public void subBalanta(string _sub)
        {
            float sub = float.Parse(_sub);
            suma -= sub;
        }

        public string retBalantaString()
        {
            string cont = suma.ToString();
            return cont;
        }

        public float retBalanta()
        {
            return suma;
        }

        public void introducereFisier(string fisier, string retBalantaString)
        {
            File.WriteAllText(fisier, retBalantaString);
        }

        public void extragereFisier(string fisier)
        {
            string continut = File.ReadAllText(fisier);
            Console.WriteLine(continut);
        }
    }
}
