using Disklinikyonetimi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Disklinikyonetimi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public class Doktorlar
        {
            public int doktorId { get; set; }
            public string doktorAdi { get; set; }
        }

        public IActionResult anasayfa()
        {
           
                List<SelectListItem> doktorlar = new List<SelectListItem>();
            doktorlar.Add(new SelectListItem { Text = "Sefa AKMAN", Value = "1" });
            doktorlar.Add(new SelectListItem { Text = "Kübra AYSÖNDÜ", Value = "2" });
            doktorlar.Add(new SelectListItem { Text = "Ahmet AK", Value = "3" });
            doktorlar.Add(new SelectListItem { Text = "Ahsen AKPINAR", Value = "4" });
            ViewBag.Doktorlar = doktorlar;

            List<SelectListItem> islemler = new List<SelectListItem>();

            islemler.Add(new SelectListItem { Text = "Çocuk Diş Tedavisi", Value = "1" });
            islemler.Add(new SelectListItem { Text = "Diş Dolgusu", Value = "2" });
            islemler.Add(new SelectListItem { Text = "Diş Çekimi", Value = "3" });
            islemler.Add(new SelectListItem { Text = "Diş Bakımı", Value = "4" });
            islemler.Add(new SelectListItem { Text = "Diş Eti Tedavileri(Periodontoloji)", Value = "5" });
            islemler.Add(new SelectListItem { Text = "Diş Gıcırdatma", Value = "6" });
            islemler.Add(new SelectListItem { Text = "Kanal Tedavisi(Endodonti)", Value = "7" });
            islemler.Add(new SelectListItem { Text = "Diş Çapraşıklığı", Value = "8" });
            islemler.Add(new SelectListItem { Text = "Gömülü Dişler", Value = "9" });
            islemler.Add(new SelectListItem { Text = "Diş Eksikliği", Value = "10" });
            ViewBag.islemler = islemler;


            return View();
        }

        public IActionResult doktorlar()
        {
            return View();
        }
        public IActionResult islemler()
        {
            return View();
        }
        public IActionResult hakkimizda()
        {
            return View();
        }

        public IActionResult iletisim()
        {
            return View();
        }

        public enum Gender
        {
            Male,
            Female
        }
        public ActionResult Index()
        {
            return View();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
