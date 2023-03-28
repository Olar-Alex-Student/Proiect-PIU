using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestiune_Venituri_Si_Cheltuieli
{
    internal class Balanta
    {
        private float suma;
        public Balanta()
        {
            suma = 0;
        }

        public Balanta(float _sum)
        {
            suma = _sum;
        }

        void addBalanta(float _add)
        {
            suma += _add;
        }

        void subBalanta(float _sub)
        {
            suma -= _sub;
        }

        public float retBalanta()
        {
            return suma;
        }
    }
}
