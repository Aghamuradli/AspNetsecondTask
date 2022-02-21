using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
