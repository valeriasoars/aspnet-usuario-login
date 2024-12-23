using System.Diagnostics;
using aspnet_login_usuario.Dto.Login;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_login_usuario.Controllers
{
    public class HomeController : Controller
    {

        Uri baseUrl = new Uri("https://localhost:7066/api");

        private readonly HttpClient _httpClient;
        public HomeController(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = baseUrl;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registrar() 
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
