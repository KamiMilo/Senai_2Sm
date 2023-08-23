using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.filme.manha.Repositories;
using WebApi.Filmes.Domains;
using WebApi.Filmes.Interface;
using WebApi.Filmes.Repositories;

namespace WebApi.Filmes.Controllers
{
    //Define que a rota de uma resquisição será no seguinte formato:
    //Dominio/Api/Nomedocontroller
    //ex  http://Localhost:/api/genero

    //Define que é um controlador de Api
    [Route("api/[controller]")]
    //Define que o tipo de resposta da Api será no formato Json
    [ApiController]
    [Produces("application/json")]

    //Método controlador que herda da controller base onde será criado os End points.
    public class GeneroController : ControllerBase 
    { 

        /// <summary>
        /// Objeto _generoRepository que ira receber todos os metodos definidos na interface IgeneroRepository
        /// </summary>
        private IGeneroRepository _generoRepository { get; set; }

        //instacia do objeto _generoRepository para que haja refêrencia aos métodos do repósitorio
        public GeneroController()
        {
            _generoRepository = new GeneroRepository();
        }
        /// <summary>
        /// End point que aciona o metodo listar todos no repositorio.
        /// </summary>
        /// <returns>Resposta para o usuario (front-end)</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
              //cria lista que recebe os dados da requisição 
            List<GeneroDomain> ListaDeGeneros=_generoRepository.ListarTodos();
              //Retorna a lista no formato json com o status code Ok(200)
            return Ok(ListaDeGeneros);
            }

            //Retorna a lista com o status code Bad Request (400) e a mensagem de erro
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

    }
}
