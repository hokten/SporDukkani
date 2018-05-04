using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SporDukkani.WebUI.Models
{
    public class SayfalamaSinifi
    {
        public int ToplamKayitSayisi { get; set; }
        public int SayfaBasinaDusenKayitSayisi { get; set; }
        public int BulunulanSayfa { get; set; }
        public int ToplamSayfaSayisi
        {
            get
            {
                return (int)Math.Ceiling((decimal)ToplamKayitSayisi / SayfaBasinaDusenKayitSayisi);
            }
        }
    }
}