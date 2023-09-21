using apiweb_eventplus.Domains;
using apiweb_eventplus.Interfaces;
using apiweb_eventplus.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace apiweb_eventplus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TiposEventoController : ControllerBase
    {
        private ITiposEventoRepository _tiposEventoRepository;

        public TiposEventoController()
        {
            _tiposEventoRepository = new TiposEventoRepository();
        }
        /// <summary>
        /// End Point que aciona o método de Cadastrar
        /// </summary>
        /// <param name="novoTipoDeEvento"></param>
        /// <returns>Status Code</returns>


        [HttpPost]
        public IActionResult Post(TiposEvento novoTipoDeEvento)
        {
            try
            {
                _tiposEventoRepository.Cadastrar(novoTipoDeEvento);

                return StatusCode(201);
            }

            catch (Exception e)
            {
                return BadRequest(e.Message);
            }


        }
        /// <summary>
        /// End Point que aciona o Método de Listar
        /// </summary>
        /// <returns>Lista de Tipos de Evento</returns>


        [HttpGet]

        public IActionResult Get()
        {
            try
            {
                return Ok(_tiposEventoRepository.Listar());
            }

            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
        /// <summary>
        /// End Point que aciona o método de Deletar.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>NoContent</returns>

        [HttpDelete]

        public IActionResult Delete(Guid id)
        {
          
            try
            {
              _tiposEventoRepository.Deletar(id);

                return NoContent();
            }

            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// End Point que aciona o método Buscar por Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>

        [HttpGet("{id}")]
        public IActionResult GetBuscarPorId(Guid Id)
        {
            try
            {
                return Ok(_tiposEventoRepository.Listar());

            }

            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// End Point que aciona o Método de Atualizar
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Tipoevento"></param>
        /// <returns></returns>

        [HttpPut]

        public IActionResult Put(TiposEvento Tipoevento, Guid id)
        {
            try
            {
                _tiposEventoRepository.Atualizar(id, Tipoevento);

                return NoContent();

            }

            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


    }
}
