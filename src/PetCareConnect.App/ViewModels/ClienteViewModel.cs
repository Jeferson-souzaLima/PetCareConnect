
namespace PetCareConnect.App.ViewModels
{
    public abstract class ClienteViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Imagem { get; set; }

    }
}