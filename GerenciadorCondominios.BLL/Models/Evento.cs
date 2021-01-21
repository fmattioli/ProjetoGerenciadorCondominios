using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GerenciadorCondominios.BLL.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
        [Required(ErrorMessage = "O Campo {0} é obrigátorio")]
        [StringLength(50, ErrorMessage = "Use menos caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigátorio")]
        public DateTime Data { get; set; }
        public string  UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
