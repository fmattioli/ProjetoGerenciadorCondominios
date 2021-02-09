using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorCondominios.ViewModels
{
    public class RegistroViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigátorio")]
        [StringLength(40, ErrorMessage = "Use menos caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigátorio")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigátorio")]
        public string Telefone { get; set; }
        public string Foto { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigátorio")]
        [StringLength(40, ErrorMessage = "Use menos caracteres")]
        [EmailAddress(ErrorMessage ="Digite um e-mail válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigátorio")]
        [StringLength(40, ErrorMessage = "Use menos caracteres")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigátorio")]
        [StringLength(40, ErrorMessage = "Use menos caracteres")]
        [DataType(DataType.Password)]
        [Display(Name ="Confirme sua senha")]
        [Compare("Senha", ErrorMessage = "As senhas não são iguais")]
        public string SenhaConfirmada { get; set; }
    }
}
