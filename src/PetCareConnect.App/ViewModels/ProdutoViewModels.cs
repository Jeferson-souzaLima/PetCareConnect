using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PetCareConnect.App.ViewModels
{
    public class Class
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome do produto deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição do produto é obrigatória")]
        [StringLength(100, ErrorMessage = "A descrição do produto deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O valor do produto é obrigatório")]
        public decimal Valor { get; set; }

        [DisplayName("Imagem do Produto")]
        public IFormFile ImageUpload { get; set; }

        public string Imagem { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        [Required(ErrorMessage = "A categoria é obrigatória")]
        [DisplayName("Categoria")]
        public Guid CategoriaId { get; set; }

        
    }
}
