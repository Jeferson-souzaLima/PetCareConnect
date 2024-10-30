
using System.ComponentModel.DataAnnotations;

namespace PetCareConnect.App.ViewModels
{
    public abstract class EnderecoViewModel 
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage="O campo deve ser Preenchido")]
        public string Cep { get; set; }
        [Required(ErrorMessage = "O campo deve ser Preenchido")]
        public string Estado { get; set; }
        [Required(ErrorMessage = "O campo deve ser Preenchido")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "O campo deve ser Preenchido")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "O campo deve ser Preenchido")]
        public string Logradouro { get; set; }

        /* EF Relational */
        //public Cliente Cliente { get; set; }
    }
}
