using CoreKitaplık.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreKitaplık.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var ktp = new List<Kitaplar>()
            {
                new Kitaplar()
                {ID =1,KitapAd="İnce Memed",Yazar="Yaşar Kemal"},
                new Kitaplar()
                {ID =2,KitapAd="Huzur",Yazar="Ahmet Hamdi Tanpınar"},
                 new Kitaplar()
                {ID =3,KitapAd="Aşk-ı Memnu",Yazar="Halid Ziya Uşaklıgil"},
                 new Kitaplar()
                 {ID =4,KitapAd="Devlet Ana",Yazar="Kemal Tahir"}

            };
            return View(ktp);

        }

        public IActionResult deneme()
        { return View(); }

        public IActionResult StatikTema()
            { return View(); }
    }


}
