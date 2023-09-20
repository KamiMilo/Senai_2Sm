using apiweb_eventplus.Domains;
using apiweb_eventplus.Interfaces;
using apiweb_eventplus.Repositories;
using apiweb_eventplus.ViewModels2;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace apiweb_eventplus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class LoginController : ControllerBase
    {

        private readonly IUsuarioRepository _usuarioRepository;

        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Post(LoginViewModels usuario)
        {
            try
            {
                Usuario usuarioBuscado = _usuarioRepository.BuscarPorEmail(usuario.Email, usuario.Senha);

                if(usuarioBuscado == null) 
                {
                    return StatusCode(401, "Email ou senha inválidos");
                }

                //Lógica do Token

                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Email,usuarioBuscado.Email!),
                    new Claim(JwtRegisteredClaimNames.Name,usuarioBuscado.Nome!),
                    new Claim(JwtRegisteredClaimNames.Jti,usuarioBuscado.IdUsuario.ToString()),
                    new Claim(ClaimTypes.Role,usuarioBuscado.TiposUsuario!.Titulo!)

                };

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("apiweb_eventplus-chave-autenticacao"));

                var creds = new SigningCredentials (key,SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "apiweb_eventplus",
                    audience: "apiweb_eventplus",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(6),
                    signingCredentials: creds

                    );

                return Ok(token);

            }

            catch (Exception )
            {
                throw;
            }

        }
    }
}
