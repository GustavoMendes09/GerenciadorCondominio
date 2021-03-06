using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorCondominios.ViewModels
{
    public class AtualizarViewModel
    {
        public string UsuarioId { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(40, ErrorMessage = "Use menos caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public string Telefone { get; set; }

        public string Foto { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(40, ErrorMessage = "Use menos caracteres")]
        [EmailAddress(ErrorMessage = "Email Inválido")]
        public string Email { get; set; }
    }
}
