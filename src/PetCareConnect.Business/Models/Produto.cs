using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareConnect.Business.Models
{
    public class Produto : BaseEntity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        //public string Categoria { get; set; }
    }

    public class CategoriaProduto : BaseEntity
    {
        public string Nome { get; set; }
    }
}
