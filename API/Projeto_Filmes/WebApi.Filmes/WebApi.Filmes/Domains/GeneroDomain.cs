using System.ComponentModel.DataAnnotations;

namespace WebApi.Filmes.Domains
{
    /// <summary>
    /// Classe que Representa a Entidade(Tabela) Genero
    /// </summary>
    public class GeneroDomain
    {
        public int IdGenero { get; set; }

        [Required(ErrorMessage = "O nome do genêro é Obrigatório!")]
        public string? Nome { get; set; }

    }
  
}

