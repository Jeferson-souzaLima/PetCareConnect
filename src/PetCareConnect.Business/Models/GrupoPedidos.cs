using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareConnect.Business.Models
{
   public class GrupoPedidos
    {
        public int GrupoPedidoId { get; set; }
        public IEnumerable<Pedidos> Pedidos { get; set; }
        public Cliente Cliente { get; set; }
        public string Nome { get; set; }
    }
}
