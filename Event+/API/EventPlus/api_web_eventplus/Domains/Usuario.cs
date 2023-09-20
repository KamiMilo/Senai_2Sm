using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiweb_eventplus.Domains
{
    [Table(nameof(Usuario))]
    //Identificar que o campo email é unico
    [Index(nameof(Email),IsUnique=true)]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; }


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome é obrigatório")]

        public string? Nome { get; set; }


        [Column (TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O email do Usúario é obrigatório")]

        public string? Email { get; set;}

        [Column(TypeName = "CHAR(60)")]
        [Required(ErrorMessage = "a senha do Usúario é obrigatória")]
        [StringLength(60 , MinimumLength = 5 , ErrorMessage = "Senha deve conter no mínimo 6 caracteres")]
       
        public string? Senha { get; set; }

        //Referencia foreign key tabela tipo de usuario 

        [Required(ErrorMessage = "Informe o Tipo de Usúario")]
        public Guid IdTipoUsuario { get; set; }

        [ForeignKey(nameof(IdTipoUsuario))]
        public TiposUsuario? TiposUsuario { get; set; }
    }
}
