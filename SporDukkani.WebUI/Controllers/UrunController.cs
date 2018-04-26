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
        public UrunController(IUrunlerFabrikasi fbr)
        {
            this.fabrika = fbr;
        }

        // GET: Urun
        public ActionResult Listele()
        {
            return View(fabrika.Urunler);
        }
    }
}