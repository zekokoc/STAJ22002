using CoreKitaplık.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;



namespace CoreKitaplık.ViewComponents
{
    public class YeniKitaplar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var kitaplistesi = new List<Kitaplar>
            {
                new Kitaplar
                {

                    ID=5,
                    KitapAd="Korku",
                    Yazar="Zweig"
                },
                 new Kitaplar
                 {
                     ID =6,
                     KitapAd="Anna Karanina",
                     Yazar="Tolstoy"
                 }
            };
            return View(kitaplistesi);
        }
    }
}
