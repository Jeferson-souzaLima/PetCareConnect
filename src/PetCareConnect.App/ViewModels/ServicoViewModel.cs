using System.ComponentModel.DataAnnotations;

namespace PetCareConnect.App.ViewModels
{
    public class ServicoViewModel
    {
        [Key]
        public int ServicoId { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "Qual o serviço?", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [StringLength(300, ErrorMessage = "Descreva o serviço...", MinimumLength = 2)]
        public string Descricao { get; set; }
        public PrestadorViewModel prestador { get; set; }
        public bool Disponivel { get; set; }

        [Required(ErrorMessage = "O Valor é obrigatório.")]
        [StringLength(100, ErrorMessage = "O Valor é obrigatório.", MinimumLength = 2)]
        public int Valor { get; set; }
        public PedidosViewModel PedidosViewModel { get; set; }
        public FreelancerViewModel FreelancerViewModel { get; set; }
        public PetShopViewModel PetShopViewModel { get; set; }
    }
}
