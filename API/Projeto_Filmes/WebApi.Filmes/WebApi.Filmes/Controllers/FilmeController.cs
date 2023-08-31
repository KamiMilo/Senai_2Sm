using Microsoft.AspNetCore.Mvc;
using webapi.filme.manha.Repositories;
using WebApi.Filmes.Domains;
using WebApi.Filmes.Interface;
using WebApi.Filmes.Repositories.WebApi.Filmes.Repositories;

namespace WebApi.Filmes.Controllers
{

    //Define que a rota de uma resquisição será no seguinte formato:
    //Dominio/Api/Nomedocontroller
    //ex  http://Localhost:5167/api/filme

    [Route("api/[controller]")]
    //Define que o tipo de resposta da Api será no formato Json
    [ApiController]
    [Produces("application/json")]
    public class FilmeController : ControllerBase
    {

        private IFilmeRepository _filmerepository { get; set; }

        //instacia do objeto _generoRepository para que haja refêrencia aos métodos do repósitorio
        public FilmeController()
        {
            _filmerepository = new FilmeRepository();
        }

        /// <summary>
        /// End point que aciona o método listar do Répositorio de filme.
        /// </summary>
        /// <returns>Resposta para o usuario (front-end)</returns>

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                //cria lista para receber os dados.
                List<FilmeDomain> ListaDeFilmes = _filmerepository.ListarTodos();

                //Retorna a lista no formato json com o status code Ok(200)
                return Ok(ListaDeFilmes);
            }

            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }
        /// <summary>
        /// End point que aciona o método de cadastro.
        /// </summary>
        /// <param name="Novofilme"></param>
        /// <returns>Status Code</returns>

        [HttpPost]
        public IActionResult Post(FilmeDomain Novofilme)
        {
            try
            {
                _filmerepository.Cadastrar(Novofilme);

                return StatusCode(201);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }
        /// <summary>
        /// End point que aciona o método deletar no repositório
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Status Code</returns>

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                _filmerepository.Deletar(id);
                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            try
            {
                //guardar objeto do método dentro de outro objeto
                FilmeDomain FilmeBuscado = _filmerepository.BuscarPorId(id);


                if(FilmeBuscado == null)
                  {

                }

            }

            catch
            {

            }
        }





    }
}

