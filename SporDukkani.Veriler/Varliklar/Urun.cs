using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporDukkani.Veriler.Varliklar
{
    class Urun
    {
        public int UrunID { get; set; }
        public string Isim { get; set; }
        public string Aciklama { get; set; }
        public decimal Fiyat { get; set; }
        public string Kategori { get; set; }
    }
}
