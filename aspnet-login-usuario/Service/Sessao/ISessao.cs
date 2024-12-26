using aspnet_login_usuario.Models;

namespace aspnet_login_usuario.Service.Sessao
{
    public interface ISessao
    {
        UsuarioModel BuscarSessao();
        void CriarSessao(UsuarioModel usuario);
        void RemoverSessao();
    }
}
