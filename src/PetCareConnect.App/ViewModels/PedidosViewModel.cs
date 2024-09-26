using System.ComponentModel.DataAnnotations;
using static PetCareConnect.App.ViewModels.ClienteViewModel;

namespace PetCareConnect.App.ViewModels
{
    public class PedidosViewModel
    {
        [Key]
        public int PedidoId { get; set; }
        public IEnumerable<ProdutoViewModel> Produtos { get; set; }
        public IEnumerable<ServicoViewModel> Servicos { get; set; }
        public Cliente Cliente { get; set; }
        public GrupoPedidosViewModel GrupoPedidos { get; set; }
    }
}
