using System.Data.SqlClient;
using webapi.filmes.manha.Domains;
using webapi.filmes.manha.Interfaces;

namespace webapi.filmes.manha.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public string StringConexao = "Data Source = NOTE07-S14; Initial Catalog = Filmes; User Id = sa; Pwd = Senai@134";
        public UsuarioDomain Login(string email, string senha)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryLogin = "SELECT IdUsuario,Email,Permissao FROM Usuario WHERE Email = @Email AND Senha = @Senha";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryLogin,con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        UsuarioDomain usuario = new UsuarioDomain
                        {
                            IdUsuario = Convert.ToInt32(rdr["IdUsuario"]),

                            Email = rdr["Email"].ToString(),

                            Permissao = rdr["Permissao"].ToString()
                        };
                        return usuario;
                    }
                    return null;
                }
            }
        }
    }
}
