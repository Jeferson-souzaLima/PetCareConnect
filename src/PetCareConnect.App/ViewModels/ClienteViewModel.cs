using PetCareConnect.Business.Models;

namespace PetCareConnect.App.ViewModels
{
    public abstract class ClienteViewModel : BaseEntity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Imagem { get; set; }
    }
}