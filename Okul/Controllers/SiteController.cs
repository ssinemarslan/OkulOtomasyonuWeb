using Microsoft.AspNetCore.Mvc;

namespace Okul.Controllers
{
    public class SiteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
