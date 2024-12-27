using System.ComponentModel.DataAnnotations;

namespace aspnet_login_usuario.Dto.Usuario
{
    public class UsuarioEdicaoDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o usuário")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Digite o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o sobrenome")]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "Digite o email")]
        public string Email { get; set; }
        public DateTime DataAlteracao { get; set; } = DateTime.Now;
    }
}
