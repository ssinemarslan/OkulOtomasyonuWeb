using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Okul.Models;
using Dapper;
namespace Okul.Controllers
{
    public class DerslerController : Controller
    {
        // GET: Dersler
        public ActionResult Index()
        {
            return View(DP.ReturnList<DerslerModel>("DersListele"));
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
                param.Add("@DersNo", id);
                return View(DP.ReturnList<DerslerModel>("DersSirala", param).FirstOrDefault<DerslerModel>());

            }
        }
        [HttpPost]
        public ActionResult EY(DerslerModel dersler)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@DersNo", dersler.DersNo);
            param.Add("@DersAdi", dersler.DersAdi);
            param.Add("@Kredi", dersler.Kredi);
            DP.ExReturn("DersEY", param);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@DersNo", id);
            DP.ExReturn("DersSil", param);
            return RedirectToAction("Index");
        }
    }
}