using Microsoft.AspNetCore.Mvc;

namespace Motor.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
