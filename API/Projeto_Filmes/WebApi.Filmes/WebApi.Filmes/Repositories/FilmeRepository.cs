using System.Data.SqlClient;
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
            //criada a lista para os filmes.
           FilmeDomain<List> ListarFilmes = new List <FilmeDomain>();

            using (SqlConnection connection = new SqlConnection(StringConexao))
             {
                //Declaração a instrução a ser executada
                string querySelectAll = "SELECT Filme.IdFilme , Genero.IdGenero, Filme.Titulo, Genero.Nome FROM Filme INNER JOIN Genero ON Filme.IdGenero =Genero.IdGenero";

                //Ele abre a conexão com o banco de dados
                connection.Open();

                //Declara o SqlDataReader para percorrer a tabela do banco de dados
                SqlDataReader rdr;

                using (SqlCommand cmd = connection.CreateCommand(querySelectAll))
                 {
                    rdr = cmd.ExecuteReader();
                }
            }
        }
    }
}
