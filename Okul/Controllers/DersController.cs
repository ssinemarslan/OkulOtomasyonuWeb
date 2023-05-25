using Okul.Data;
using Okul.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;


namespace Okul.Controllers
{
    public class DersController : Controller
    {
        private readonly ApplicationDBContext _db;
        public DersController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var listele = _db.Derss.ToList();
            return View(listele);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Ders ders)
        {
            _db.Add(ders);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            var yenile = _db.Derss.Find(id);
            return View(yenile);
        }
        [HttpPost]
        public IActionResult Edit(int id, Ders ders)
        {
            _db.Update(ders);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var del = _db.Derss.Find(id);
            return View(del);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult Sil(int id)
        {
            var del = _db.Derss.Find(id);
            _db.Remove(del);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
