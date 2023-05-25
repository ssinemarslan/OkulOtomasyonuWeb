using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Okul.Models;
using Dapper;
namespace Okul.Controllers
{
    public class OgrencilerController : Controller
    {
        // GET: Ogrenciler
        public ActionResult Index()
        {
            return View(DP.ReturnList<OgrencilerModel>("OgrenciListele"));

        }
        public ActionResult EY(int id = 0)
        {
            if (id == 0)
            {
                return View();
            }
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@OgrenciNo", id);
                return View(DP.ReturnList<OgrencilerModel>("OgrenciSirala", param).FirstOrDefault<OgrencilerModel>());

            }
        }
        [HttpPost]
        public ActionResult EY(OgrencilerModel ogrenciler)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@OgrenciNo", ogrenciler.OgrenciNo);
            param.Add("@AdSoyad", ogrenciler.AdSoyad);
            param.Add("@Adres", ogrenciler.Adres);
            param.Add("@Sinif", ogrenciler.Sinif);
            DP.ExReturn("OgrenciEY", param);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@OgrenciNo", id);
            DP.ExReturn("OgrenciSil", param);
            return RedirectToAction("Index"); 
        }
    }
}