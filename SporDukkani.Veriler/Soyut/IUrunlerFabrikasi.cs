using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SporDukkani.Veriler.Varliklar;


namespace SporDukkani.Veriler.Soyut
{
    public interface IUrunlerFabrikasi
    {
        IEnumerable<Urun> Urunler { get; }
    }
}
