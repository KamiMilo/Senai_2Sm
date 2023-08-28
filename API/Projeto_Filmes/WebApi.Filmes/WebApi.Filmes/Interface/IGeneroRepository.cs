using WebApi.Filmes.Domains;

namespace WebApi.Filmes.Interface
{
    /// <summary>
    /// Interface Responsavél pelo repositorio Genero
    /// Definir os métodos que serão implementados pelo GeneroRepositoy
    /// </summary>
    public interface IGeneroRepository
    {
        /// <summary>
        ///serve para cadastrar um novo Genero
        /// </summary>
        /// <param name="NovoGenero">Objeto do tipo Genero</param>
        void Cadastrar(GeneroDomain NovoGenero);

        /// <summary>
        /// listar todos os objetos (Generos) Cadastrados
        /// retornalista com os objetos.
        /// </summary>
        /// <returns>Retorna os Objetos Listados</returns>
         List<GeneroDomain> ListarTodos();

        /// <summary>
        /// Atualiza um Objeto existente passando o seu Id Pelo corpo da requisição
        /// </summary>
        /// <param name="genero"></param> Objeto Atualizado(Novas Informações)
        void AtualizarIdCorpo(GeneroDomain genero);

        /// <summary>
        /// Atualiza o Objeto existente passando seu Id Pela Url
        /// </summary>
        /// <param name="Id">Id do Objeto</param>
        /// <param name="genero"></param>
        void AtualizarIdUrl (int Id, GeneroDomain genero);
        
        /// <summary>
        /// Deletar um objeto
        /// </summary>
        /// <param name="Id"></param>
        void Deletar (int Id);

        /// <summary>
        /// Busca o objeto através do Id
        /// </summary>
        /// <param name="Id">Objeto do Id a ser buscado</param>
        /// <returns>Objeto Buscado</returns>
        GeneroDomain BuscarPorId (int Id);



    }
}
