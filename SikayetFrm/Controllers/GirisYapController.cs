using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using SikayetFrm.Models;
namespace SikayetFrm.Controllers
{
    public class GirisYapController : Controller
    {
        // Context Sınıfından c isminde bir eleman türetiyoruz ki veritabanında ki tablolara ulaşabilelim
        Context c = new Context();
   
        public ActionResult Index()
        {
            return View();
        }
        //AllowAnonymus method u Kullanıcılara giriş sağlamak için yazılmıştır.Herhangi bir yetkilendirme yapsak dahi kullanıcılar giriş yapabilir.
        [AllowAnonymous]
        //Burada İstekleri Url kısmına Gönderiyoruz
        public ActionResult Login()
        {
            return View();
        }
        //Post Kımsında İse Urlde Görünmesini İstemediğimiz Kısımlar Yer alıyor
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(Admin ad)
        {
            //Kullanıcı adı ve şifreyi ad parametresinden gelen değerle eşleştiriyoruz.Ve Kontrol Ediyoruz.

            var bilgiler = c.Admins.FirstOrDefault(x => x.Kullanici == ad.Kullanici && x.Sifre == ad.Sifre);
            if (bilgiler!=null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Kullanici, false);
                Session["Kullanici"] = bilgiler.Kullanici.ToString();
                return RedirectToAction("Index" , "Home");
            }
            return View();
        }
        //Çıkış Yap Butonu Bizi Tekrardan Logine Yönlendiriyor
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}