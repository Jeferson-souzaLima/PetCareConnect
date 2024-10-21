
namespace PetCareConnect.App.ViewModels
{
    public abstract class EnderecoViewModel 
    {
        public Guid Id { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }

        /* EF Relational */
        //public Cliente Cliente { get; set; }
    }
}
