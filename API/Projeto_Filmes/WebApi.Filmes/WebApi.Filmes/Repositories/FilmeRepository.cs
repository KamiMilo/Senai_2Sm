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
        /// <summary>
        /// Cadastra um novo filme (objeto) com as informações inseridas
        /// </summary>
        /// <param name="novoFilme">Filme a ser cadastrado</param>

        public void Cadastrar(FilmeDomain NovoFilme)
        {
            using (SqlCommand con = new SqlCommand(StringConexao))
            {
                String queryInsert = "INSERT INTO Filme(IdGenero,Titulo) VALUES(@IdGenero, @Titulo)";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryInsert))
                {

                    cmd.Parameters.AddWithValue("IdGenero", NovoFilme.IdGenero),
                    cmd.Parameters.AddWithValue("Titulo", NovoFilme.Titulo);

                    cmd.ExecuteNonQuery();
                }

            }
        }

        public void Deletar(int Id)
        {
            using (SqlCommand con = new SqlCommand(StringConexao))
            {
                string queryDelete = "DELETE FROM Filme WHERE Idfilme = @IdFilmebuscado";

                 
                using (SqlCommand cmd = new SqlCommand(queryDelete))
                {
                    cmd.Parameters.AddWithValue("@IdFilmebuscado", Id);

                    con.Open();
                    
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<FilmeDomain> ListarTodos()
        {
            //criada a lista para os filmes.
          List <FilmeDomain> ListarFilmes = new List <FilmeDomain>();

            using (SqlConnection connection = new SqlConnection(StringConexao))
             {
                //Declaração a instrução a ser executada
                string querySelectAll = "SELECT Filme.IdFilme , Genero.IdGenero, Filme.Titulo, Genero.Nome FROM Filme INNER JOIN Genero ON Filme.IdGenero =Genero.IdGenero";

                //abre a conexão com o banco.
                connection.Open();
                //comando para percorrer e ler o banco.
                SqlDataReader rdr;

                using(SqlCommand cmd = new SqlCommand(querySelectAll, connection)) 
                 {
                    //Executa o comando´para percorrer e ler o banco.
                    rdr= cmd.ExecuteReader();

                    //condição para enquanto o comando de leitura for executado ele vai atribuir cada um e guardar em um objeto.
                    while (rdr.Read())
                    {

                        FilmeDomain filme = new FilmeDomain()
                        {
                            IdFilme = Convert.ToInt32(rdr["IdFilme"]),

                            IdGenero = Convert.ToInt32(rdr["IdGenero"]),

                            Titulo = rdr["Titulo"].ToString(),

                            Genero = new GeneroDomain()
                            {
                                IdGenero = Convert.ToInt32(rdr["IdGenero"]),

                                Nome = rdr["Nome"].ToString()
                            }


                        };
                        //adiciona o objeto a lista 
                        ListarFilmes.Add(filme);

                     }

                }
               
                return ListarFilmes;
            }
        }
    }
}
