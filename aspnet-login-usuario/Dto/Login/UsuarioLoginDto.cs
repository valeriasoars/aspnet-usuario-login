using System.ComponentModel.DataAnnotations;

namespace aspnet_login_usuario.Dto.Login
{
    public class UsuarioLoginDto
    {
        [Required(ErrorMessage = "Digite o email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite a senha")]
        public string Senha { get; set; }
    }
}
