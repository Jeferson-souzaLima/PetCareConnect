using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareConnect.Business.Models
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public Cliente Cliente {  get; set; }
        public Prestador prestador { get; set; }
        public Vendedor Vendedor {  get; set; }
        public Freelancer Freelancer { get; set; }
        public PetShop PetShop { get; set; }

    }
}
