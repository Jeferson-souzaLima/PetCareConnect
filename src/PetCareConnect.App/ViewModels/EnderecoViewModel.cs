using System.ComponentModel.DataAnnotations;

namespace PetCareConnect.Business.Models
{
    public abstract class EnderecoViewModel : BaseEntity
    {
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }

        /* EF Relational */
        //public Cliente Cliente { get; set; }
    }
}
