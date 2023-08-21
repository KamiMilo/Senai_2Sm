using WebApi.Filmes.Domains;

namespace WebApi.Filmes.Interface
{
    /// <summary>
    /// Interface Responsavél pelo repositorio Genero
    /// Definir os métodos que serão implementados pelo GeneroRepositoy
    /// </summary>
    public interface IGeneroRepository
    {
        void Cadastrar(GeneroDomain NovoGenero);

         List<GeneroDomain> ListarTodos();

        void Atualizar(GeneroDomain genero);

        void Deletar (int Id);

    }
}
