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
        /// <summary>
        /// Serve para cadastrar um novo filme
        /// </summary>
        /// <param name="NovoFilme"></param>
        void Cadastrar(FilmeDomain NovoFilme);

        /// <summary>
        /// Serve para listar os filmes existentes no banco de dados
        /// </summary>
        /// <returns>lista de filme(objeto)</returns>
        List<FilmeDomain> ListarTodos();

        /// <summary>
        ///  Atualiza um Objeto existente passando o seu Id Pelo corpo da requisição
        /// </summary>
        /// <param name="filme"></param> Objeto Atualizado(Novas Informações)
        void AtualizarIdCorpo(FilmeDomain filme);

        /// <summary>
        ///  Atualiza um Objeto existente passando o Url Pelo corpo da requisição
        /// </summary>
        /// <param name="filme"></param> Objeto Atualizado(Novas Informações)
        void AtualizarIdUrl(int Id, FilmeDomain filme);
        /// <summary>
        /// Deleta um objeto passando o seu Id
        /// </summary>
        /// <param name="Id"></param> Id do objeto
        void Deletar(int Id);

        /// <summary>
        /// Busca objeto através do seu id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>objeto buscado</returns>
        GeneroDomain BuscarPorId(int Id);
    }
}
