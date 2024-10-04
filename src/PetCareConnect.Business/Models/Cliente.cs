using PetCareConnect.Business.Enums;

namespace PetCareConnect.Business.Models
{
    public class Cliente : BaseEntity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Imagem { get; set; }
        
        /* EF Relational */ 
        public EnderecoCliente EnderecoCliente { get; set; }

        //public IEnumerable<Pedido> Pedido { get; set; }
        //public IEnumerable<GrupoPedido> GrupoPedido { get; set; }
        public IEnumerable<Pet> Pet { get; set; }
    }

    public class Pet : BaseEntity
    {
        public string Nome { get; set; }
        public string Raca { get; set; }
        public Porte Porte { get; set; }
        public string Imagem { get; set; }

        //EF Relational
        public Cliente Cliente { set; get; }
        //public Cliente ClienteId { set; get; }
    }
    public class EnderecoCliente : BaseEntity
    {
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }

        /* EF Relational */
        //public Cliente Cliente { get; set; }
        public Guid ClienteId { get; set; }
    }
}
