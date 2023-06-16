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
        /*
         
         */

        public IActionResult anasayfa()
        {
            String connectionString = "Data Source=localhost;Initial Catalog=disklinikyonetimi;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
                List<SelectListItem> doktorlar = new List<SelectListItem>();
            ////foreach ile db.Categories deki kategorileri listemize ekliyoruz
            /*foreach (var item in connection)
            {   //Text = Görünen kısımdır. Kategori ismini yazdıyoruz
                //Value = Değer kısmıdır.ID değerini atıyoruz
                doktorlar.Add(new SelectListItem { Text = item.CategoryName, Value = item.CategoryID.ToString() });
            }*/
            ////Dinamik bir yapı oluşturup kategoriler list mizi view mize göndereceğiz
            //bunun için viewbag kullanıyorum
            ViewBag.Doktorlar = doktorlar;

            List<SelectListItem> islemler = new List<SelectListItem>();

            islemler.Add(new SelectListItem { Text = "İşlem 1", Value = "1" });
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
            //veritabanımızdan instance alıyoruz.
            //Disklinikyonetimi db = new Disklinikyonetimi();
            //bir list oluştuyoruz selectlistitem tipi alacak
            //foreach ile db.Categories deki kategorileri listemize ekliyoruz
            //foreach (var item in db.DOKTORLAR.ToList())
            //{   //Text = Görünen kısımdır. Kategori ismini yazdıyoruz
            //    //Value = Değer kısmıdır.ID değerini atıyoruz
            //doktorAdi.Add(new SelectListItem { Text = item.doktorAdi, Value = item.DoktorId.ToString() });
            //}
            //Dinamik bir yapı oluşturup kategoriler list mizi view mize göndereceğiz
            //bunun için viewbag kullanıyorum
            //List<SelectListItem> doktorlar = new List<SelectListItem>();

            //islemler.Add(new SelectListItem { Text = "Doktor 1", Value = "1" });
            //   ViewBag.Doktorlar = doktorlar;
                return View();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
