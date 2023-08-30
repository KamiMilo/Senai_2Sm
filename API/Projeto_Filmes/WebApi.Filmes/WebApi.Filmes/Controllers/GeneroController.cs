using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
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
        /// Endpoint para acionar o método listar todos no repósitorio.
        /// </summary>
        /// <returns>Resposta para o usuario (front-end)</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                //cria lista que recebe os dados da requisição 
                List<GeneroDomain> ListaDeGeneros = _generoRepository.ListarTodos();
                //Retorna a lista no formato json com o status code Ok(200)
                return Ok(ListaDeGeneros);
            }

            //Retorna a lista com o status code Bad Request (400) e a mensagem de erro
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        /// <summary>
        /// EndPoint para acionar o método de cadastro.
        /// </summary>
        /// <param name="novoGenero">objeto recebido na requisição</param>
        /// <returns>status code 201(Created)</returns>
        [HttpPost]

        public IActionResult Post(GeneroDomain novoGenero)
        {

            try
            {
                //Fazendo a chamada ara o método atraves do  _generoRepository que acessa o GeneroRepository 
                _generoRepository.Cadastrar(novoGenero);

                //Retorna um status Code 201(Created)
                return StatusCode(201);

            }

            catch (Exception erro)
            {
                //Retorna um status code 400 (Bad Request)e uma mensagem de erro
                return BadRequest(erro.Message);
            }
        }
        /// <summary>
        /// Endpoint que deleta um objeto pelo seu id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            try
            {
                _generoRepository.Deletar(Id);

                return StatusCode(204);
            }

            catch (Exception erro)
            {
                //Retorna um status code 400 (Bad Request)e uma mensagem de erro
                return BadRequest(erro.Message);
            }
        }

        /// <summary>
        /// Endpoint que Busca um Genero atraves do seu id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Gênero encontrado</returns>

        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {

            try
            {
                //guardar objeto do método dentro de outro objeto
                GeneroDomain GeneroBuscado = _generoRepository.BuscarPorId(Id);

                if (GeneroBuscado == null)
                {
                    return NotFound("Nenhum Gênero foi encontrado");
                }

                return Ok(GeneroBuscado);

            }

            //Retorna a lista com o status code Bad Request (400) e a mensagem de erro
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }


        /// <summary>
        /// Endpoint que aciona o método de atualizar dados por id no corpo
        /// </summary>
        /// <param name="Id">Id do Objeto</param>
        /// <returns>genero</returns>
        [HttpPut]
        public IActionResult Put(GeneroDomain Genero)
        {
            try
            {
                GeneroDomain GeneroEncontrado = _generoRepository.AtualizarIdCorpo(Genero.IdGenero);

                if (GeneroEncontrado == null!)
                {
                    try
                    {
                        _generoRepository.AtualizarIdCorpo(Genero,Id);
                        return StatusCode(201);

                    }

                    catch (Exception erro)
                    {
                        return BadRequest(erro.Message);
                    }

                }

                return BadRequest("Gênero não encontrado");
             }

                catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }

        }

        /// <summary>
        /// Endpoint que aciona o método de atualizar dados pela url
        /// </summary>
        /// <param name="Id">Id do Objeto</param>
        /// <returns>genero</returns>

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, GeneroDomain Genero)
        {
            try
            {
                _generoRepository.AtualizarIdUrl(id, Genero);

                return Ok(204);
            }

            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }
    }
}


