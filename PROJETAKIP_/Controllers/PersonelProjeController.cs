using PROJETAKIP_.Models.DataContext;
using PROJETAKIP_.Models.ProjeTakip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PROJETAKIP.Controllers
{
    public class PersonelProjeController : Controller
    {
        private ProjeTakipDBContext db = new ProjeTakipDBContext();  //VERİ TABANI BAĞLANTISI


        // GET: PersonelProje
        public ActionResult Index()
        {
            var projelistele = db.PersonelProjeleris.ToList();
            return View(projelistele);
        }

        public ActionResult Create()
        {
            ViewBag.PersonelBilgileriId = new SelectList(db.PersonelBilgileris, "PersonelBilgileriId", "AdSoyad");
            return View();
        }
        [HttpPost]
        public ActionResult Create(PersonelProjeleri projeObj, int[] PersonelBilgileriId)
        {

            foreach (var x in PersonelBilgileriId)
            {
                projeObj.PersonelBilgileris.Add(db.PersonelBilgileris.Find(x));
            }
            projeObj.OlusturmaTarihi = DateTime.Now;
            db.PersonelProjeleris.Add(projeObj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var projeObj = db.PersonelProjeleris.Find(id);
            return View(projeObj);
        }
        [HttpPost]

        public ActionResult Edit(PersonelProjeleri projeObj)
        {
            var projeDbObj = db.PersonelProjeleris.Find(projeObj.PersonelProjeId);
            projeDbObj.ProjeAciklama = projeObj.ProjeAciklama;
            projeDbObj.ProjeBaslik = projeObj.ProjeBaslik;
            projeDbObj.TamamlanmaOranı = projeObj.TamamlanmaOranı;
            projeDbObj.OncelikDurumu = projeObj.OncelikDurumu;
            projeDbObj.TamamlanmaTarihi = DateTime.Now;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Tamamla(int id)
        {
            var projeObj = db.PersonelProjeleris.Find(id);
            projeObj.TamamlanmaDurumu = true;
            projeObj.TamamlanmaOranı = 100;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}