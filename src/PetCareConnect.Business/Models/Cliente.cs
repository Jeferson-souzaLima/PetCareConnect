using PetCareConnect.Business.Enums;

namespace PetCareConnect.Business.Models
{
    public abstract class Cliente : BaseEntity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Imagem { get; set; }
        //public Endereco Endereco { get; set; }
        //public TipoCliente TipoCliente { get; set; }

        //protected Cliente(string nome, string documento, string imagem)
        //{
        //    Nome = nome;
        //    Documento = documento;
        //    Imagem = imagem;
        //}
        //protected Cliente()
        //{

        //}

    }

}
