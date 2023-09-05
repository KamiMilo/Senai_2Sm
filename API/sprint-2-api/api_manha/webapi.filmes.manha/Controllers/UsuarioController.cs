using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using webapi.filmes.manha.Domains;
using webapi.filmes.manha.Interfaces;
using webapi.filmes.manha.Repositories;

namespace webapi.filmes.manha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Login(UsuarioDomain usuario)
        {
            try
            {
                UsuarioDomain usuarioBuscado = _usuarioRepository.Login(usuario.Email, usuario.Senha);

                if (usuarioBuscado == null)
                {
                    return NotFound("Email ou Senha Inválidos !");
                }
                //Caso encontre o usuario prossegue para a criação do token

                //Definir as informações(CLAIN) do indice que serão fornecidas no token (PAYLOAD)

                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Jti,usuarioBuscado.IdUsuario.ToString()),
                    new Claim(JwtRegisteredClaimNames.Email,usuarioBuscado.Email),
                    new Claim(ClaimTypes.Role,usuarioBuscado.Permissao),

                    //existe a possibilidade de criar uma Claim personalizada

                    new Claim("Claim Personalizada","Valor da Claim personalizada")

                };

                //Definir a Chave de acesso ao token
                //Chave-simetrica: Usa a mesma chave para gerar e devolver o valor

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("filmes-chave=autenticacao-webapi-dev"));

                //Definir credenciais do token(HEADER)

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                //Gerar Token
                var token = new JwtSecurityToken
                 (
                    //emissor do token
                    issuer: "webapi.filmes.manha",

                     //Destinatario do token
                     audience: "webapi.filmes.manha",

                     //Dados definidos nas claims (Informações)
                     claims: claims,

                     //tempo de expiração do token
                     expires: DateTime.Now.AddMinutes(5),

                     //Credenciais do token
                     signingCredentials: creds
                    );


                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });

            }

            catch (Exception erro) { 
                return BadRequest(erro.Message);
            }

            //

        }
    }
}
