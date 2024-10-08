using PetCareConnect.Business.Enums;
using System.ComponentModel.DataAnnotations;

namespace PetCareConnect.Business.Models
{
    public class ClienteViewModel : BaseEntity
    {
        [Key]

        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(200, ErrorMessage = "O nome deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Somente números são permitidos. Remova quaisquer caracteres especiais e tente novamente.")]
        [StringLength(14, ErrorMessage = "O Documento deve ter entre {2} e {1} numeros, sem ", MinimumLength = 9)]
        public string Documento { get; set; }
        //public IFormFile ImageUpload { get; set; }
        public string Imagem { get; set; }
        
        /* EF Relational */ 
        public EnderecoClienteViewModel EnderecoCliente { get; set; }

        //public IEnumerable<Pedido> Pedido { get; set; }
        //public IEnumerable<GrupoPedido> GrupoPedido { get; set; }
        public IEnumerable<PetViewModel> PetViewModel { get; set; }
    }

    public class PetViewModel : BaseEntity
    {
        [Key]

        [Required(ErrorMessage = "O nome do Pet é obrigatório")]
        [StringLength(200, ErrorMessage = "O nome do Pet deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [StringLength(100, ErrorMessage = "A Raça deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Raca { get; set; }
        public Porte Porte { get; set; }
        //public IFormFile ImageUpload { get; set; }
        public string Imagem { get; set; }

        //EF Relational
        public ClienteViewModel Cliente { set; get; }
        //public Cliente ClienteId { set; get; }
    }
    public class EnderecoClienteViewModel : BaseEntity
    {
        [Key]

        [Required(ErrorMessage = "O CEP é obrigatório.")]
        [StringLength(8, ErrorMessage = "O CEP deve ter {1} caracteres.", MinimumLength = 8)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O estado é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome estado deve ter entre {1} e {2} caracteres.", MinimumLength = 2)]
        public string Estado { get; set; }

        [Required(ErrorMessage = "A cidade é obrigatório.")]
        [StringLength(100, ErrorMessage = "A cidade deve ter entre {1} e {2} caracteres.", MinimumLength = 2)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O Bairro é obrigatório.")]
        [StringLength(100, ErrorMessage = "O Bairro deve ter entre {1} e {2} caracteres.", MinimumLength = 2)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O Logradouro é obrigatório.")]
        [StringLength(100, ErrorMessage = "O Logradouro deve ter entre {1} e {2} caracteres.", MinimumLength = 2)]
        public string Logradouro { get; set; }

        /* EF Relational */
        public ClienteViewModel Cliente { get; set; }
        
    }
}
