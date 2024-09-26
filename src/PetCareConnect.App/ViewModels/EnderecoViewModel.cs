using System.ComponentModel.DataAnnotations;
using static PetCareConnect.App.ViewModels.ClienteViewModel;

namespace PetCareConnect.App.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public int EnderecoId { get; set; } 

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
        public ClienteViewModel Cliente { get; set; }
        public PrestadorViewModel prestador { get; set; }
        public VendedorViewModel Vendedor { get; set; }
        public FreelancerViewModel Freelancer { get; set; }
        public PetShopViewModel PetShop { get; set; }
    }
}
