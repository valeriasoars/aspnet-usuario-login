using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_login_usuario.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Login()
        {
            return View();
        }
    }
}
