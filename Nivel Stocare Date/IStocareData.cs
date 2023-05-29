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
        void AddCont(Cont c);
        List<Cont> GetModificari();
        Cont GetCont(string tip);
        Cont GetCont(int idStudent);
        bool UpdateCont(Cont s);
    }
}
