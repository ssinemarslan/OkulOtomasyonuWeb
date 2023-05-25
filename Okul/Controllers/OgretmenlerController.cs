using Microsoft.AspNetCore.Mvc;

namespace Okul.Controllers
{
    public class OgretmenlerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
