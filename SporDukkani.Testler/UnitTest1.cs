using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Moq;
using SporDukkani.Veriler.Varliklar;
using SporDukkani.Veriler.Soyut;
using SporDukkani.WebUI.Controllers;
using SporDukkani.WebUI.Models;
using SporDukkani.WebUI.HTMLHelpers;
using System.Web.Mvc;


namespace SporDukkani.Testler
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sayfalama_Testi()
        {
            Mock<IUrunlerFabrikasi> kalip_veri = new Mock<IUrunlerFabrikasi>();
            kalip_veri.Setup(m => m.Urunler).Returns(new Urun[]
            {
                new Urun {UrunID=1, Isim="Urun1" },
                new Urun {UrunID=2, Isim="Urun2" },
                new Urun {UrunID=3, Isim="Urun3" },
                new Urun {UrunID=4, Isim="Urun4" },
                new Urun {UrunID=5, Isim="Urun5" },
            });
            UrunController controller = new UrunController(kalip_veri.Object);
            controller.SayfaBasinaKayit = 3;

            IEnumerable<Urun> result = (IEnumerable<Urun>)controller.Listele(2).Model;
            Urun[] urunDizisi = result.ToArray();

            Assert.IsTrue(urunDizisi.Length == 2);
            Assert.AreEqual(urunDizisi[0].Isim, "Urun4");
            Assert.AreEqual(urunDizisi[1].Isim, "Urun5");

        }
        [TestMethod]
        public void Sayfalama_Numaralari_Uretilmesi_Testi()
        {
            HtmlHelper yardimcim = null;
            SayfalamaSinifi sayfa = new SayfalamaSinifi
            {
                BulunulanSayfa = 2,
                ToplamKayitSayisi = 28,
                SayfaBasinaDusenKayitSayisi = 10
            };
            Func<int, string> sayfaAdresiTemsilci = i => "Page" + i;
            MvcHtmlString sonuc = yardimcim.SayfaBaglantilari(sayfa, sayfaAdresiTemsilci);
            Assert.AreEqual(@"<a class=""btn btn-default"" href=""Page1"">1</a>" +
                @"<a class=""btn btn-default btn-primary selected"" href=""Page2"">2</a>" +
                @"<a class=""btn btn-default"" href=""Page3"">3</a>", sonuc.ToString());
        }
    }
}
