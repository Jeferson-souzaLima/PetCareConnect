using PetCareConnect.Business.Enums;
using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

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
        public string Nome { get; set; }
        public string Raca { get; set; }
        public Porte Porte { get; set; }
        public string Imagem { get; set; }

        //EF Relational
        public CompradorViewModel Comprador { set; get; }
    }

    public class EnderecoCompradorViewModel : EnderecoViewModel
    {
        public CompradorViewModel Comprador { get; set; }
    }
}
