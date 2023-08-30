using System.Data.SqlClient;
using System.Runtime.Intrinsics.Arm;
using WebApi.Filmes.Domains;
using WebApi.Filmes.Interface;

namespace webapi.filme.manha.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {
        /// <summary>
        /// string de conexao com o banco de dados que recebe os seguintes parametros
        /// Data Source : nome do servidor
        /// Initial Catalog : nome do banco de dados
        /// Autenticacao :
        ///     - Windows : integrated Security = true;
        ///     - SQL : User id : sa; Pwd : Senha
        /// </summary>
        public string StringConexao = "Data Source = NOTE07-S14; Initial Catalog = Filmes; User Id = sa; Pwd = Senai@134";

        void IGeneroRepository.AtualizarIdCorpo(GeneroDomain Genero)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                    string queryUpdate = "UPDATE Genero SET Nome = @Nome WHERE IdGenero = @IdGenero";
                    
                   //Declara o comando sql passando a query que será executada0 como paramêtro
                    using (SqlCommand cmd = new SqlCommand(queryUpdate, con))
                    {
                      //passa os valores para nos parametros
                        cmd.Parameters.AddWithValue("@Nome", Genero.Nome);
                        cmd.Parameters.AddWithValue("@IdGenero", Genero.IdGenero);

                        con.Open();

                        cmd.ExecuteNonQuery();
                    }              
            }
        }

        //SqlConection
        //Query
        //sqlcommand (parametros)
        // rdr = cmd.ExecuteReader();
        void IGeneroRepository.AtualizarIdUrl(int id, GeneroDomain Genero)
        {
                using (SqlConnection con = new SqlConnection(StringConexao))
                {
                //comando da query no banco de dados
                    string queryUpdateByUrl = "UPDATE Genero SET Nome = @Nome WHERE IdGenero = @IdGenero";

                    using (SqlCommand cmd = new SqlCommand(queryUpdateByUrl, con))
                    {
                    cmd.Parameters.AddWithValue("@Nome", Genero.Nome);
                    cmd.Parameters.AddWithValue("@IdGenero", Genero.IdGenero);

                    con.Open();

                    cmd.ExecuteNonQuery();
                     }

                }
            
        }

        //Buscar um Genero atraves do seu id
        GeneroDomain IGeneroRepository.BuscarPorId(int id)
        {
            //objeto criado para receber o genero buscado

            using (SqlConnection con = new SqlConnection(StringConexao))
            {

                string querySelectPorId = "SELECT IdGenero, Nome FROM Genero WHERE IdGenero = @IdGenero";

                //Abre a Conexão com o banco de todos
                con.Open();

                SqlDataReader rdr;


                //Declara o SqlCommand passando a Query que será executada e a conexão com o bd
                using (SqlCommand cmd = new SqlCommand(querySelectPorId, con))
                {
                    cmd.Parameters.AddWithValue("@IdGenero", id);

                    rdr = cmd.ExecuteReader();


                    if (rdr.Read())
                    {
                        GeneroDomain generoBuscado = new GeneroDomain()
                        {
                            IdGenero = Convert.ToInt32(rdr["IdGenero"]),

                            Nome = rdr["Nome"].ToString()

                        };

                        return generoBuscado;
                    }

                    else
                    {
                        return null;
                    }

                }
            }

        }


        /// <summary>
        /// Cadastrar um novo Gênero
        /// </summary>
        /// <param name="novoGenero">objeto com as informações que serão cadastradas</param>
        void IGeneroRepository.Cadastrar(GeneroDomain novoGenero)
        {
            //Declara a conexão passando a string de conexão como Parâmetro
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                //Declara a Query que será executada
                string queryInsert = "INSERT INTO Genero (Nome) VALUES(@Nome)";

                //Declara o SqlCommand passando a Query que será executada e a conexão com o bd
                using (SqlCommand cmd = new SqlCommand(queryInsert,con))
                {

                    cmd.Parameters.AddWithValue("@Nome", novoGenero.Nome);

                    //Declara o SqlDataReader para percorrer a tabela do banco de dados
                    SqlDataReader read;

                    //Abre a Conexão com o banco de todos
                    con.Open();

                    //Executar a query (queryInsert)
                    cmd.ExecuteNonQuery();
                };

            }
        }

        void IGeneroRepository.Deletar(int id)
        {

            //Declara a conexão passando a string de conexão como Parâmetro
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                //Declara a Query que será executada
                string queryDelete = "DELETE FROM Genero WHERE IdGenero = @IdGenero";

                using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                {

                    cmd.Parameters.AddWithValue("@IdGenero", id);

                    con.Open();

                    cmd.ExecuteNonQuery();

                }

            }
        }

        List<GeneroDomain> IGeneroRepository.ListarTodos()
        {
            //Cria uma lista de objetos do tipo gênero
            List<GeneroDomain> ListaGeneros = new List<GeneroDomain>();

            using (SqlConnection connection = new SqlConnection(StringConexao))
            {
                //Declaração a instrução a ser executada
                string querySelectAll = "SELECT IdGenero,Nome FROM Genero";

                //Ele abre a conexão com o banco de dados
                connection.Open();

                //Declara o SqlDataReader para percorrer a tabela do banco de dados
                SqlDataReader rdr;

                //Declara o SqlCommand passsando a query que sera executada e a conexão com o bd
                using (SqlCommand cmd = new SqlCommand(querySelectAll, connection))
                {
                    //Executa a query e armazena os dados no rdr
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        GeneroDomain genero = new GeneroDomain()
                        {
                            //Atribui a propiedade IdGenero o valor recebido no rdr
                            IdGenero = Convert.ToInt32(rdr[0]),
                            //Atribui a propiedade Nome o valor recebido no rdr
                            Nome = rdr["Nome"].ToString(),
                        };

                        //Adiciona cada objeto dentro da lista
                        ListaGeneros.Add(genero);
                    }
                }
            }
            //Retorna a lista
            return ListaGeneros;
        }
    }
}


