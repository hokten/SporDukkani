using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SporDukkani.Veriler.Varliklar;
using System.Data.Entity;

namespace SporDukkani.Veriler.Somut
{
    public class EFVtBaglam : DbContext
    {
        public DbSet<Urun> Urunler { get; set; }
    }
}
