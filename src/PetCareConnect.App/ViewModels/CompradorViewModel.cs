

using PetCareConnect.App.ViewModels;
using PetCareConnect.Business.Enums;

namespace PetCareConnect.Business.Models
{
    public class CompradorViewModel : Cliente
    {
        /* EF Relational */ 

        //public IEnumerable<Pedido> Pedido { get; set; }
        //public IEnumerable<GrupoPedido> GrupoPedido { get; set; }
        public IEnumerable<PetViewModel> Pets { get; set; }
        public EnderecoCompradorViewModel Endereco { get; set; }
        
    }

    public class PetViewModel : BaseEntity
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Raca { get; set; }
        public Porte Porte { get; set; }
        public string Imagem { get; set; }

        //EF Relational
        public CompradorViewModel Comprador { set; get; }
    }

    public class EnderecoCompradorViewModel : EnderecoViewModel
    {
        public Guid Id { get; set; }
        public CompradorViewModel Comprador { get; set; }
    }
}
