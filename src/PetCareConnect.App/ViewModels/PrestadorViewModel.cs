
using PetCareConnect.Business.Enums;

namespace PetCareConnect.App.ViewModels
{
    public class PrestadorViewModel : ClienteViewModel
    {
        public Guid Id { get; set; }
        public TipoPrestador TipoPrestador { get; set; }
        public EnderecoPrestadorViewModel Endereco { get; set; }
    }

    public class EnderecoPrestadorViewModel : EnderecoViewModel
    {
        public Guid Id { get; set; }
        public PrestadorViewModel Prestador { get; set; }

    }
}
