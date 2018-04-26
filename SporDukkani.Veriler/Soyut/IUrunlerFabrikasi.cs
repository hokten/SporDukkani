using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SporDukkani.Veriler.Varliklar;


namespace SporDukkani.Veriler.Soyut
{
    interface IUrunlerFabrikasi
    {
        IEnumerable<Urun> Urunler { get; }
    }
}
