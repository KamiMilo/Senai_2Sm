using apiweb_eventplus.Contexts;
using apiweb_eventplus.Domains;
using apiweb_eventplus.Interfaces;
using apiweb_eventplus.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.DataAnnotations;

namespace apiweb_eventplus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class InstituicaoController : ControllerBase
    {
        private IInstituicaoRepository _instituicaoRepository;

        public InstituicaoController()
        {
            _instituicaoRepository = new InstitucaoRepository();
        }


        [HttpPost]

        public IActionResult Post(Instituicao novaInstituicao)
        {
            try
            {
                _instituicaoRepository.cadastrar(novaInstituicao);

                return StatusCode(201);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_instituicaoRepository.Listar());
            }

            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }

        [HttpDelete]

        public IActionResult Delete(Guid id)
        {
            try
            {
                _instituicaoRepository.Deletar(id);

                return StatusCode(200);
            }

            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }

    }
}
