using PetCareConnect.Business.Enums;
using System.ComponentModel.DataAnnotations;


namespace PetCareConnect.Business.Models
{
    public class VendedorViewModel : BaseEntity
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
        public TipoPrestador TipoPrestador { get; set; }


        /* EF Relational */
        public EnderecoVendedorViewModel EnderecoVendedorViewModel { get; set; }
    }

    public class EnderecoVendedorViewModel : BaseEntity
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
        public VendedorViewModel Vendedor { get; set; }
        public Guid VendedorId { get; set; }
    }
}
