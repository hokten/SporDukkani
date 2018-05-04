using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.Mvc;
using SporDukkani.WebUI.Models;

namespace SporDukkani.WebUI.HTMLHelpers
{
    public static class SayfalamaHelpers
    {
        public static MvcHtmlString SayfaBaglantilari(this HtmlHelper html,
            SayfalamaSinifi sayfaNesnesi,
            Func<int, string> sayfaAdresi)
        {
            StringBuilder sonuc = new StringBuilder();
            for(int i=1; i<=sayfaNesnesi.ToplamSayfaSayisi; i++)
            {
                TagBuilder etiket = new TagBuilder("a");
                etiket.MergeAttribute("href", sayfaAdresi(i));
                etiket.InnerHtml = i.ToString();
                if(i==sayfaNesnesi.BulunulanSayfa)
                {
                    etiket.AddCssClass("selected");
                    etiket.AddCssClass("btn-primary");
                }
                etiket.AddCssClass("btn btn-default");
                sonuc.Append(etiket.ToString());
            }
            return MvcHtmlString.Create(sonuc.ToString());
        }
    }
}