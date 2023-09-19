using apiweb_eventplus.Domains;

namespace apiweb_eventplus.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuario);

        void Deletar(Guid id);

        Usuario BuscarPorId(Guid id);

        Usuario BuscarPorEmail(string email, string senha);
    }
}
