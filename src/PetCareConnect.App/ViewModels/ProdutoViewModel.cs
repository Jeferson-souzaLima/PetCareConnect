using System.ComponentModel.DataAnnotations;

namespace PetCareConnect.App.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "Diga-nos seu nome...", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatório.")]
        [StringLength(100, ErrorMessage = "Descreva o seu produto.", MinimumLength = 2)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O valor é obrigatório.")]
        [StringLength(100, ErrorMessage = "O valor é obrigatório.", MinimumLength = 2)]
        public double Valor { get; set; }

        [Required]
        public IFormFile ImageUpload { get; set; }
        public string Imagem { get; set; }
        public bool Disponivel { get; set; }
        public enum TipoPrestador;
        public PedidosViewModel PedidosViewModel { get; set; }
        public VendedorViewModel VendedorViewModel { get; set; }
        public PetShopViewModel PetShopViewModel { get; set; }
    }

    public class CategoriaProdutosViewModel
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "O nome da Categoria é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome da Categoria é obrigatório.", MinimumLength = 2)]
        public string Nome { get; set; }
    }
}
