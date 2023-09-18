using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiweb_eventplus.Domains
{
    [Table(nameof(Instituicao))]
    [Index(nameof(CNPJ),IsUnique= true)]
    public class Instituicao
    {
        public Guid IdInstituicao { get; set; }

        [Column(TypeName = "CHAR(14)")]
        [Required(ErrorMessage = "CNPJ Obrigatório")]
        [StringLength(14)]

        public string? CNPJ { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Endereço Obrigatório")]
        public string? Endereco { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome da Instituição Obrigatório")]
        public string? NomeFantasia { get; set; }



    }
}
