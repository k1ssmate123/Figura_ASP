using FiguraRestaurant.Models;
using FiguraRestaurant.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FiguraRestaurant.Controllers
{
    public class UserController : Controller
    {
        IUserRepository repo;

        public UserController(IUserRepository repo)
        {
            this.repo = repo;
        }


        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            User currentUser = repo.Login(email, password);
            if (currentUser != null)
            {
                HttpContext.Session.SetString("id","currentUser.Id.ToString()");
                HttpContext.Session.SetString("name", "currentUser.Name");
                var test = HttpContext.Session.GetString("id");

                return RedirectToAction(nameof(Index), "Site");
            }
            else
            {
                return RedirectToAction(nameof(Login),"Site");
            }

          
        }

        [HttpPost]
        public ActionResult Register(string name, string email, string password)
        {
            repo.Register(name, email, password);
            return RedirectToAction(nameof(Index), "Site");
        }


    }
}
