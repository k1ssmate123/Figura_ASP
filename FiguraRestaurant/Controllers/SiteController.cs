using Microsoft.AspNetCore.Mvc;

namespace FiguraRestaurant.Controllers
{
    public class SiteController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            return View("/Views/Public/index.cshtml");
        }
    }
}
