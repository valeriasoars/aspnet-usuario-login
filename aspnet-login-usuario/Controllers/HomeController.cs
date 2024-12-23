using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_login_usuario.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
    }
}
