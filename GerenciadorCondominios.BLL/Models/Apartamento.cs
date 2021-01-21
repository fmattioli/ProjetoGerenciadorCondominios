using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GerenciadorCondominios.BLL.Models
{
    public class Apartamento
    {
        public int ApartamentoId { get; set; }
        [Required(ErrorMessage = "O Campo {0} é obrigátorio")]
        [Range(0, 1000, ErrorMessage = "Valor inválido")]
        [Display(Name = "Número")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigátorio")]
        [Range(0, 25, ErrorMessage = "Valor inválido")]
        public int Andar { get; set; }

        public int Foto { get; set; }
        public string MoradorId { get; set; }
        public virtual Usuario Morador { get; set; }
        public string ProprietarioId { get; set; }
        public virtual Usuario Proprietario { get; set; }
    }
}
