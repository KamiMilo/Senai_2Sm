using System.Reflection;
using WebApi.Filmes.Domains;

namespace WebApi.Filmes.Interface
{
    /// <summary>
    /// Interface Responsavél pelo repositorio Filme
    /// Definir os métodos que serão implementados pelo FilmeRepositoy
    /// </summary>
    public interface IFilmeRepository
    {
        void Cadastrar(FilmeDomain NovoFilme);

        List<FilmeDomain> ListarTodos();

        void AtualizarIdCorpo(FilmeDomain filme);

        void AtualizarIdUrl(int Id, FilmeDomain filme);

        void Deletar(int Id);

        GeneroDomain BuscarPorId(int Id);
    }
}
