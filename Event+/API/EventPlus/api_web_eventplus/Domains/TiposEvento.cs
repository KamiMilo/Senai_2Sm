using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiweb_eventplus.Domains
{
    [Table (nameof(TiposEvento))]
    public class TiposEvento
    {
        [Key]
        public Guid? IdTipoEvento { get; set;} = Guid.NewGuid();

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="O Titulo do evento é obrigatório")]
        public string? Titulo { get; set;}
    }
}
