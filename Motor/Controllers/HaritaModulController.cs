using Microsoft.AspNetCore.Mvc;
using Motor.Models;

namespace Motor.Controllers
{
    public class HaritaModulController : Controller
    {
        public IActionResult Index()
        {

            return View();
            //Harita Modulu kodlar....
            //Arac Takip Modulü Tamamlandı....

        }
        [HttpPost]
        public IActionResult Index(User model)
        {
            if (ModelState.IsValid)
            {
                // Veritabanına kaydetme işlemi burada yapılabilir
                // Örn: _context.Users.Add(model); _context.SaveChanges();

                ViewBag.Message = "Kullanıcı başarıyla eklendi.";
                return View();
            }

            return View(model);
        }
    }
}
