using System.ComponentModel.DataAnnotations;
using static PetCareConnect.App.ViewModels.ClienteViewModel;

namespace PetCareConnect.App.ViewModels
{
    public class GrupoPedidosViewModel
    {
        [Key]
        public int GrupoPedidoId { get; set; }
        public IEnumerable<PedidosViewModel> Pedidos { get; set; }
        public Cliente Cliente { get; set; }

        [Required(ErrorMessage = "Insira o nome do seu novo grupo de pedidos!")]
        [StringLength(100, ErrorMessage = "Insira o nome do seu novo grupo de pedidos!", MinimumLength = 2)]
        public string Nome { get; set; }
    }
}
