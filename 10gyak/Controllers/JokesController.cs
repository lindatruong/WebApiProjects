using Microsoft.AspNetCore.Mvc;

namespace _10gyak.Controllers
{
    public class JokesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
