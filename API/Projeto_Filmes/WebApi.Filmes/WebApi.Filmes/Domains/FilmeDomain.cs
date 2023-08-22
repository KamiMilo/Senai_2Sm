using System.ComponentModel.DataAnnotations;

namespace WebApi.Filmes.Domains
{
    public class FilmeDomain
    {
        public int IdFilme { get; set; }

        public int IdGenero { get; set; }
        public GeneroDomain Genero { get; set; }

       [Required(ErrorMessage = "O titulo do filme dever Obrigatorio!")] 
        public string Titulo { get; set; }

    }
}
