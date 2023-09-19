using apiweb_eventplus.Contexts;
using apiweb_eventplus.Domains;
using apiweb_eventplus.Interfaces;

namespace apiweb_eventplus.Repositories
{
    public class TiposUsuarioRepository : ITiposUsuarioRepository
    {
        private readonly EventContext _eventContext;
        public TiposUsuarioRepository()
        {
            _eventContext = new EventContext();
        }

        public void Atualizar(Guid id, TiposUsuario tipoUsuario)
        {
            throw new NotImplementedException();
        }

        public TiposUsuario BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(TiposUsuario tipoUsuario)
        {
            _eventContext.TiposUsuario.Add(tipoUsuario);

            _eventContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<TiposUsuario> Listar(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
