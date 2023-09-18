using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiweb_eventplus.Domains
{
    [Table(nameof(TiposUsuario))]
    public class TiposUsuario
    {
        [Key]
        public Guid IdTipoUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O Tipo de usúario é obrigatório")]
        public string? Titulo { get; set; }
    }
}
