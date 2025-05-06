using Microsoft.AspNetCore.Mvc;

namespace FiguraRestaurant.Controllers
{
    public class SiteController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            return View("/Views/Public/index.cshtml");
        }

        public IActionResult Login()
        {
            return View("/Views/Public/login.cshtml");
        }

        public IActionResult Register()
        {
            return View("/Views/Public/register.cshtml");
        }
    }
}
