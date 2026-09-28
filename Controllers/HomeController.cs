using Microsoft.AspNetCore.Mvc;

namespace Cau1.Controllers
{
    public class HomeController : Controller
    {
        // /Home/Weekend (cũng là trang mặc định)
        public IActionResult Weekend()
        {
            return View();
        }
    }
}
