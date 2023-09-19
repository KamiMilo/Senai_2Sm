using apiweb_eventplus.Contexts;
using apiweb_eventplus.Domains;
using apiweb_eventplus.Interfaces;
using apiweb_eventplus.Utils;

namespace apiweb_eventplus.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly  EventContext _eventContext;

        public UsuarioRepository() //CTOR cria o metodo construtor
        {
            _eventContext = new EventContext();
        }

        public Usuario BuscarPorEmail(string email, string senha)
        {
            try
            {
                //expressão lambida que traz o primeiro email que for encontrado que seja igual ao da variavel
                //(u(variavel de busca) =>(vai para) u.Email (tabela Email) == (que for igual ao) email  )

                Usuario usuarioBuscado = _eventContext.Usuario.FirstOrDefault(u => u.Email == email)!;
                if (usuarioBuscado != null)
                {
                    //Confere a senha
                    bool confere = Criptografia.CompararHash(senha, usuarioBuscado.Senha!);

                    if (confere)
                    {
                        return usuarioBuscado;
                    }
                }
                return null!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Usuario BuscarPorId(Guid id)
        {
            try
            {
                Usuario usuarioBuscado = _eventContext.Usuario
                    .Select(u => new Usuario
                    {
                        IdUsuario = u.IdUsuario,
                        Nome = u.Nome,
                        TiposUsuario = new TiposUsuario
                        {
                            IdTipoUsuario = u.IdTipoUsuario,
                            Titulo = u.TiposUsuario!.Titulo
                        }
                    }).FirstOrDefault(u => u.IdUsuario == id)!;

                if (usuarioBuscado != null)
                {
                    return usuarioBuscado;
                }
                return null!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Usuario usuario)
        {
            try
            {
                usuario.Senha = Criptografia.GerarHash(usuario.Senha!);
                _eventContext.Usuario.Add(usuario);
                _eventContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
