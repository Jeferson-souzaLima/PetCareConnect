namespace PetCareConnect.Business.Models
{
    public class Produto : BaseEntity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        //public string Categoria { get; set; }

        //public Produto(string nome, string descricao, string imagem, decimal valor) 
        //{ }

        //public Produto()
        //{
        //}
    }

    public class CategoriaProduto : BaseEntity
    {
        public string Nome { get; set; }
    }
}
