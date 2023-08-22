using WebApi.Filmes.Domains;
using WebApi.Filmes.Interface;

namespace WebApi.Filmes.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {
        /// <summary>
        /// String de conexão com o Banco de dados
        /// DATASOURCE: initial catalog: Nome do Banco de Dados
        /// AUTENTICAÇÃO SQL:User Id = NomeDoUser; pwd= Senha";
        /// WINDOWS: Integrated Security =True
        /// </summary>
        /// 

        private string StringConexao = "DataSource NOTE07-S14 ;initial catalog = Filmes;User Id = sa; pwd=Senai@134";
        public void AtualizarIdCorpo(GeneroDomain genero)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int Id, GeneroDomain genero)
        {
            throw new NotImplementedException();
        }

        public GeneroDomain BuscarPorId(int Id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(GeneroDomain NovoGenero)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int Id)
        {
            throw new NotImplementedException();
        }

        public List<GeneroDomain> ListarTodos()
        {
            throw new NotImplementedException();
        }


    }
}
