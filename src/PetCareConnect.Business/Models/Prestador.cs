using Microsoft.AspNetCore.Http;
using PetCareConnect.Business.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareConnect.Business.Models
{
    public abstract class Prestador
    {
        public int PrestadorId { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public Endereco Endereco { get; set; }
        public string Imagem { get; set; }
        public TipoPrestador TipoPrestador { get; set; }
    }

    public class Vendedor : Prestador
    {
        public IEnumerable<Produtos> Produtos { get; set; }
    }

    public class Freelancer : Prestador
    {
        public IEnumerable<Servicos> Servicos { get; set; }
    }

    public class PetShop : Prestador
    {
        public IEnumerable<Servicos> Servicos { get; set; }
        public IEnumerable<Produtos> Produtos { get; set; }
    }

}
