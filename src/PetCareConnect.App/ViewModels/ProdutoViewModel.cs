
namespace PetCareConnect.App.ViewModels
{
    public class ProdutoViewModel 
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public IFormFile ImagemUpload { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        //public string Categoria { get; set; }
        
    }

    public class CategoriaProdutoViewModel 
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
    }
}
