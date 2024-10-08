using PetCareConnect.Business.Enums;
using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;


namespace PetCareConnect.Business.Models
{
    public class Vendedor : Prestador
    {
        public Vendedor(string nome, string documento, string imagem, EnderecoPrestador enderecoPrestador) : base(nome, documento, imagem, TipoPrestador.Vendedor, enderecoPrestador)
        {
            
        }
        protected Vendedor()
        {

        }
    }

}
