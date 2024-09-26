using System.ComponentModel.DataAnnotations;
using static PetCareConnect.App.ViewModels.ClienteViewModel;

namespace PetCareConnect.App.ViewModels
{
    public class ClienteViewModel
    {
        public class Cliente
        {
            [Key]
            public int ClienteId { get; set; }

            [Required(ErrorMessage = "O nome é obrigatório.")]
            [StringLength(100, ErrorMessage = "Diga-nos seu nome...", MinimumLength = 2)]
            public string Nome { get; set; }

            [Required(ErrorMessage = "O documento é obrigatório")]
            [StringLength(100, ErrorMessage = "O documento deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
            public int Documento { get; set; } //CPF ou CNPJ

            [Required]
            public EnderecoViewModel EnderecoViewModel { get; set; }
            public IEnumerable<PedidosViewModel> PedidosViewModel { get; set; }
            public IEnumerable<GrupoPedidosViewModel> GrupoPedidosViewModel { get; set; }

            public IFormFile ImageUpload { get; set; }
            public string Imagem { get; set; } //Foto de Perfil
            public IEnumerable<PetsViewModel> Pets { get; set; } //Meus Pets
        }
    }
    public class PetsViewModel
    {
        [Key]
        public int PetId { get; set; }
        public Cliente Cliente { get; set; }

        [Required(ErrorMessage = "Informe o nome do seu Pet.")]
        [StringLength(100, ErrorMessage = "Informe o nome do seu Pet.", MinimumLength = 2)]
        public string Nome { get; set; }

        [StringLength(100, ErrorMessage = "Informe a idade do seu Pet.", MinimumLength = 2)]
        public int Idade { get; set; }

        public IFormFile ImageUpload { get; set; }   
        public string Imagem { get; set; }
    }
}
