using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SporDukkani.Veriler.Varliklar;
using SporDukkani.Veriler.Soyut;


namespace SporDukkani.Veriler.Somut
{
    public class EFUrunFabrikasi : IUrunlerFabrikasi
    {
        private EFVtBaglam veritabani = new EFVtBaglam();

        public IEnumerable<Urun> Urunler
        {
            get
            {
                return veritabani.Urunler;
            }
        }

    }
}
