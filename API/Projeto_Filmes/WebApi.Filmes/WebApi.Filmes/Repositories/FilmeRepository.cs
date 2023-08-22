using WebApi.Filmes.Domains;
using WebApi.Filmes.Interface;

namespace WebApi.Filmes.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {

        private string StringConexao = "DataSource NOTE07-S14 ;initial catalog = Filmes;User Id = sa; pwd=Senai@134";
        public void AtualizarIdCorpo(FilmeDomain filme)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int Id, FilmeDomain filme)
        {
            throw new NotImplementedException();
        }

        public GeneroDomain BuscarPorId(int Id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(FilmeDomain NovoFilme)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int Id)
        {
            throw new NotImplementedException();
        }

        public List<FilmeDomain> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
