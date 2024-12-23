using System.ComponentModel.DataAnnotations;

namespace aspnet_login_usuario.Dto.Usuario
{
    public class UsuarioCriacaoDto
    {

        [Required(ErrorMessage = "Digite o nome de usuário")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Digite o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o sobrenome")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Digite o email")]
        public string Email { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Digite a senha")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Digite a confirmação da senha"),
            Compare("Senha", ErrorMessage = "As senhas estão divergentes")]
        public string ConfirmaSenha { get; set; }
    }
}
