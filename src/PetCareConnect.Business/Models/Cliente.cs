namespace PetCareConnect.Business.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public int Documento { get; set; } //CPF ou CNPJ
        public Endereco Endereco { get; set; }
        public IEnumerable<Pedidos> Pedidos { get; set; }
        public IEnumerable<GrupoPedidos> GrupoPedidos { get; set; }
        public string Imagem { get; set; } //Foto de Perfil
        public IEnumerable<Pets> Pets { get; set; } //Meus Pets
    }

    public class Pets
    {
        public int PetId { get; set; }
        public Cliente Cliente { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Imagem { get; set; }
    }
}
