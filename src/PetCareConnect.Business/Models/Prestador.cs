using PetCareConnect.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareConnect.Business.Models
{
    public abstract class Prestador : Cliente
    {
        public TipoPrestador TipoPrestador { get; set; }
        public EnderecoPrestador Endereco { get; set; }

        protected Prestador(string nome, string documento, string imagem, TipoPrestador tipoPrestador, EnderecoPrestador enderecoPrestador) : base( nome, documento, imagem)
        {
            TipoPrestador = tipoPrestador;
            Endereco = enderecoPrestador;
        }
        protected Prestador()
        {

        }

    }

    public class EnderecoPrestador : Endereco
    {
        public Prestador Prestador { get; set; }

    }
    

}
