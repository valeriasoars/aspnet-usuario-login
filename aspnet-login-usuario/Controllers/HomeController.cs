using System.Diagnostics;
using aspnet_login_usuario.Dto.Login;
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

        [HttpPost]
        public IActionResult Login(UsuarioLoginDto usuarioLoginDto)
        {
            return View(usuarioLoginDto);
        }
    }
}
