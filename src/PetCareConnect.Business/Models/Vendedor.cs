using PetCareConnect.Business.Enums;


namespace PetCareConnect.Business.Models
{
    public class Vendedor : BaseEntity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Imagem { get; set; }
        public TipoPrestador TipoPrestador { get; set; }


        /* EF Relational */
        public EnderecoVendedor EnderecoVendedor { get; set; }
    }

    public class EnderecoVendedor : BaseEntity
    {
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }

        /* EF Relational */
        public Vendedor Vendedor { get; set; }
        public Guid VendedorId { get; set; }
    }
}
