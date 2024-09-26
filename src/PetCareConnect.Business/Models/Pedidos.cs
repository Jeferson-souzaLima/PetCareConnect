using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareConnect.Business.Models
{
    public class Pedidos
    {
        public int PedidoId { get; set; }
        public IEnumerable<Produtos> Produtos { get; set; }
        public IEnumerable<Servicos> Servicos{ get; set; }
        public Cliente Cliente { get; set; }
        public GrupoPedidos GrupoPedidos { get; set; }
    }
}
