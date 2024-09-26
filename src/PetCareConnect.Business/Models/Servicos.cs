using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareConnect.Business.Models
{
    public class Servicos
    {
        public int ServicoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Prestador prestador { get; set; }
        public bool Disponivel { get; set; }
        public int Valor { get; set; }
        public Pedidos Pedidos { get; set; }
        public Freelancer Freelancer { get; set; }
        public PetShop PetShop { get; set; }
    }
}
