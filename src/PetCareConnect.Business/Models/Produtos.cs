using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareConnect.Business.Models
{
    public class Produtos
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public string Imagem { get; set; }
        public bool Disponivel { get; set; }
        public enum TipoPrestador;
        public Pedidos Pedidos { get; set; }
        public Vendedor Vendedor { get; set; }
        public PetShop PetShop { get; set; }
    }
    public class CategoriaProdutos
    {
        public string Nome { get; set; }
        public int CategoriaId { get; set; }
    }
}
