using System.Diagnostics;
using System.Text;
using aspnet_login_usuario.Dto.Login;
using aspnet_login_usuario.Dto.Usuario;
using aspnet_login_usuario.Models;
using aspnet_login_usuario.Service.Sessao;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace aspnet_login_usuario.Controllers
{
    public class HomeController : Controller
    {

        Uri baseUrl = new Uri("https://localhost:7066/api");

        private readonly HttpClient _httpClient;
        private readonly ISessao _sessaoInterface;
        public HomeController(HttpClient httpClient, ISessao sessaoInterface )
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = baseUrl;
            _sessaoInterface = sessaoInterface;
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

        [HttpGet]
        public IActionResult ListarUsuario() 
        {
            return View();
        }




        [HttpPost]
        public async Task<IActionResult> Login(UsuarioLoginDto usuarioLoginDto)
        {
            if(ModelState.IsValid)
            {
                ResponseModel<UsuarioModel> usuario = new ResponseModel<UsuarioModel>();

                var httpContent = new StringContent(JsonConvert.SerializeObject(usuarioLoginDto), Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _httpClient.PostAsync(_httpClient.BaseAddress + "/Login/login", httpContent);

                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsStringAsync().Result;
                    usuario = JsonConvert.DeserializeObject<ResponseModel<UsuarioModel>>(data);
                }

                if(usuario.Status == false)
                {
                    return View(usuarioLoginDto);
                }


                // criar sessao com o usuário que se logou
                _sessaoInterface.CriarSessao(usuario.Dados);


                return RedirectToAction("ListarUsuario");
            }
            else
            {
                return View(usuarioLoginDto);
            }


            
        }

        [HttpPost]
        public async Task<IActionResult> Registrar(UsuarioCriacaoDto usuarioCriacaoDto)
        {

            if (ModelState.IsValid)
            {
                ResponseModel<UsuarioModel> usuario = new ResponseModel<UsuarioModel>();

                var httpContent = new StringContent(JsonConvert.SerializeObject(usuarioCriacaoDto), Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _httpClient.PostAsync(_httpClient.BaseAddress + "/Login/register", httpContent);

                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsStringAsync().Result;
                    usuario = JsonConvert.DeserializeObject<ResponseModel<UsuarioModel>>(data);

                }

                if(usuario.Status == false)
                {
                    return View(usuarioCriacaoDto);
                }

                return RedirectToAction("Login");

            }
            else
            {
                return View(usuarioCriacaoDto);
            }
          
        }


    }
}
