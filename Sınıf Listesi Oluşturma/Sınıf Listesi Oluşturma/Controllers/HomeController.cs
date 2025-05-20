using Sınıf_Listesi_Oluşturma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sınıf_Listesi_Oluşturma.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var ogrListe = new List<Ogrenci>()
            {
                new Ogrenci(){ogrId=1 , ogrNo=79 , ogrName="Ahmet", ogrYas=23},
                new Ogrenci(){ogrId=2 , ogrNo=179 , ogrName="Ahmet2", ogrYas=232},
                new Ogrenci(){ogrId=3 , ogrNo=279 , ogrName="Ahmet3", ogrYas=233},
            };
            return View(ogrListe);
        }
    }
}