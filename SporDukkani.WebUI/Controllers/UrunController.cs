using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SporDukkani.Veriler.Soyut;
using SporDukkani.Veriler.Varliklar;

namespace SporDukkani.WebUI.Controllers
{
    public class UrunController : Controller
    {
        private IUrunlerFabrikasi fabrika;
        public int SayfaBasinaKayit = 2;


        public UrunController(IUrunlerFabrikasi fbr)
        {
            this.fabrika = fbr;
        }

        // GET: Urun
        public ActionResult Listele(int sayfa=1)
        {
            return View(fabrika.Urunler
                .OrderBy(m => m.UrunID)
                .Skip((sayfa - 1) * SayfaBasinaKayit)
                .Take(SayfaBasinaKayit));
        }
    }
}