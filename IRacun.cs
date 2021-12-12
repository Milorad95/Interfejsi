using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsi
{
    interface IRacun
    {
        // metoda uplata
        void Uplata(double iznos);

        // metoda isplata
        void Isplata(double iznos);

        // properti koji ce samo vratiti Stanje racuna
        double Stanje { get; }
    }
}
