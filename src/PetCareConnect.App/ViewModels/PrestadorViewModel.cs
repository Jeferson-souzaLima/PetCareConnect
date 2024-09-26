using System.ComponentModel.DataAnnotations;

namespace PetCareConnect.App.ViewModels
{
    public class PrestadorViewModel
    {
        [Key]
        public int PrestadorId { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "Diga-nos seu nome...", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O documento é obrigatório.")]
        [StringLength(100, ErrorMessage = "O documento tem {2} á {1} caracteres.", MinimumLength = 2)]
        public int Documento { get; set; }

        [Required(ErrorMessage = "O Endereço é obrigatório.")]
        [StringLength(100, ErrorMessage = "O Endereço é obrigatório", MinimumLength = 2)]
        public EnderecoViewModel Endereco { get; set; }

        [Required]
        public IFormFile ImageUpload { get; set; }
        public string Imagem { get; set; }
        [Required]
        public int TipoPrestador { get; set; }
    }

    public class VendedorViewModel : PrestadorViewModel
    {
        public IEnumerable<ProdutoViewModel> ProdutoViewModel { get; set; }
    }

    public class FreelancerViewModel : PrestadorViewModel
    {
        public IEnumerable<ServicoViewModel> ServicoViewModel { get; set; }
    }

    public class PetShopViewModel : PrestadorViewModel
    {
        public IEnumerable<ServicoViewModel> ServicoViewModel { get; set; }
        public IEnumerable<ProdutoViewModel> ProdutoViewModel { get; set; }
    }
}
