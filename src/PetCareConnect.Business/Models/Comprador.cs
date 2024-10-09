using PetCareConnect.Business.Enums;
using static System.Net.Mime.MediaTypeNames;

namespace PetCareConnect.Business.Models
{
    public class Comprador : Cliente
    {
        
        /* EF Relational */ 

        //public IEnumerable<Pedido> Pedido { get; set; }
        //public IEnumerable<GrupoPedido> GrupoPedido { get; set; }
        public IEnumerable<Pet> Pets { get; set; }
        public EnderecoComprador Endereco { get; set; }
        //public Comprador(string nome, string documento, string imagem) : base(nome, documento, imagem)
        //{
            
        //}
        //protected Comprador()
        //{

        //}
    }

    public class Pet : BaseEntity
    {
        public string Nome { get; set; }
        public string Raca { get; set; }
        public Porte Porte { get; set; }
        public string Imagem { get; set; }

        //EF Relational
        public Comprador Comprador { set; get; }
    }
    public class EnderecoComprador : Endereco
    {
        public Comprador Comprador { get; set; }
    }
}
