using PetCareConnect.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareConnect.Business.Models
{
    public class Prestador : Cliente
    {
        public TipoPrestador TipoPrestador { get; set; }
        public EnderecoPrestador Endereco { get; set; }
    }

    public class EnderecoPrestador : Endereco
    {
        public Prestador Prestador { get; set; }

    }
    

}
