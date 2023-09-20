using System.ComponentModel.DataAnnotations;

namespace apiweb_eventplus.ViewModels2
{
    public class LoginViewModels
    {
        [Required(ErrorMessage = "Email obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "a Senha é obrigatória")]
        public string Senha { get; set; }
    }
}
