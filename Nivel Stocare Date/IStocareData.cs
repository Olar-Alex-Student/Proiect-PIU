using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cont_Utilizator;


namespace Nivel_Stocare_Date
{
    public interface IStocareData
    {
        void AddModificare(Cont cont);
        List<Cont> GetGestiune();
        Cont GetModifiacre(int sumaIntrodusa);
        Cont GetModificare(int idCont);
        bool UpdateModificare(Cont modificareActualizata);
    }
}
