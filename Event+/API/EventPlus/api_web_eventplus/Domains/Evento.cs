using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiweb_eventplus.Domains
{
    [Table(nameof(Evento))]
    public class Evento
    {
        [Key]
        public Guid? IdEvento { get; set; } = Guid.NewGuid();

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "a Data evento é obrigatório!")]
        public DateTime? DataEvento { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Informe o nome do evento!")]
        public string? NomeEvento { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = " Descrição do Evento é obrigatória!")]
        public string? Descricao { get; set; }





        //Foreign key tipo de evento
        [Required (ErrorMessage = "Informe o Tipo de evento!")]
        public Guid? IdTipoEvento { get;set; }

        [ForeignKey(nameof(IdTipoEvento))]
        public TiposEvento? TiposEvento { get; set; }

      //foreign key da Instituição
        [Required(ErrorMessage = "Informe a instituição do evento")]
        public Guid? IdInstitução { get; set; }

        [ForeignKey(nameof(IdInstitução))]
        public Instituicao? Instituicao { get; set; }
    }
}
