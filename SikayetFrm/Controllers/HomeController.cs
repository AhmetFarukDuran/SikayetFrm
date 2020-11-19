using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SikayetFrm.Models;

namespace SikayetFrm.Controllers
{
    public class HomeController : Controller
    {
        Context c = new Context();


        //Doldurulan Şikayet Formlarının Listelendiği Yer.
        
        public ActionResult Index()
        {
            var deger = c.Kisilers.ToList();
            return View(deger);
        }
        
        //Burada İstekleri Url kısmına Gönderiyoruz
        [HttpGet]
       
        public ActionResult SikayetEkle()
        {
            //DropDownList'e veritabanından şikayetleri çektiğimiz yer.
            var model = new Kisiler();
            List<SelectListItem> Liste = new List<SelectListItem>(from x in c.Sikayetlers
                                                                  select new SelectListItem
                                                                  {
                                                                      Value = x.Sikayetid.ToString(),
                                                                      Text = x.Sikayet
                                                                  }

                                                                ).ToList();
            ViewBag.l = Liste;
            //ViewBag.Sikayet = new SelectList(Sikayetler,"Sikayet","Şikayet",model.Sikayetler);
            return View();
        }
        
        //Post Kımsında İse Urlde Görünmesini İstemediğimiz Kısımlar Yer alıyor
        [HttpPost]
        //Doldurulan Formları Eklediğimiz Yer
        public ActionResult SikayetEkle(Kisiler p)
        {
            c.Kisilers.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}