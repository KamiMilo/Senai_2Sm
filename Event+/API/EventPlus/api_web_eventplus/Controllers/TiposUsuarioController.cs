﻿using apiweb_eventplus.Domains;
using apiweb_eventplus.Interfaces;
using apiweb_eventplus.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiweb_eventplus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TiposUsuarioController : ControllerBase
    {
        private ITiposUsuarioRepository _tiposUsuarioRepository;

        public TiposUsuarioController()
        {
            _tiposUsuarioRepository = new TiposUsuarioRepository();
        }

        /// <summary>
        /// End Point para cadastrar um novo tipo de usuario.
        /// </summary>
        /// <param name="tiposUsuario"></param>
        /// <returns></returns>
        //********CADASTRAR**************

        [HttpPost]
        public IActionResult Post(TiposUsuario tiposUsuario)
        {
            try
            {
                _tiposUsuarioRepository.Cadastrar(tiposUsuario);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// End Point que lista os Tipos de Usuario cadastrados
        /// </summary>
        /// <returns>Lista</returns>
        //*********Listar*******************

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
               return Ok( _tiposUsuarioRepository.Listar());

                
            }

            catch (Exception e)
            {
               return BadRequest(e.Message);

            }
        }

       
    }
}
