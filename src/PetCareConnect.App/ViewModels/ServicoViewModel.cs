using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareConnect.Business.Models
{
    public class ServicoViewModel : BaseEntity
    {
        [Key]

        [Required(ErrorMessage ="O nome do serviço é obrigatório.")]
        [StringLength(100, ErrorMessage ="O serviço tem entre {2} á {1} caracteres.", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [StringLength(400, ErrorMessage = "A descrição deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O valor é obrigatório.")]
        [StringLength(100, ErrorMessage = "O valor deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public decimal Valor { get; set; }
    }
}
