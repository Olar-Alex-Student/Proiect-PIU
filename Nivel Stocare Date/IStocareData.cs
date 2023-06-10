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
        void AddTranzactie(Tranzactie tranzactie);
        List<Tranzactie> GetTranzactii();
        Tranzactie GetTranzactieCuSuma(int sumaIntrodusa);
        Tranzactie GetTranzactieCuId(int id);
        bool UpdateModificare(Tranzactie modificareActualizata);
    }
}
