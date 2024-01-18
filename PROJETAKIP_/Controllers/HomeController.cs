using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PROJETAKIP_.Controllers
{




    //Sıfırdan İleri Seviye Proje Takip Uygulaması(.NET MVC5)


    //Kısa bir iş olan ama uzun uğraşlar sonucu tamamlanacak yaklaşık 5 farklı üniversite proje bu derse ara verdim.
    //    Projede controllerlara da not bırakacağım.Bu derse her şey tamamlandı ve kadar sorunsuz çalışıyor.
    //    (Bu ders dahil değil). 




















    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}