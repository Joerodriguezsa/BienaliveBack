using Microsoft.AspNetCore.Mvc;

namespace Api.Bienalive.Controllers
{
    public class BienaliveController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
