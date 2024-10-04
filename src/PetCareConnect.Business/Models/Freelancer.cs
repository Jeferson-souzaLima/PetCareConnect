using PetCareConnect.Business.Enums;

namespace PetCareConnect.Business.Models
{
    public class Freelancer : BaseEntity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Imagem { get; set; }
        public TipoPrestador TipoPrestador { get; set; }

        /* EF Relational */
        public EnderecoFreelancer EnderecoFreelancer { get; set; }
    }

    public class EnderecoFreelancer : BaseEntity
    {
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }

        /* EF Relational */
        public Freelancer Freelancer { get; set; }
        public Guid FreelancerId { get; set; }
    }
}
