using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareConnect.Business.Models
{
    public class ProdutoViewModel : BaseEntity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        //public string Categoria { get; set; }
    }

    public class CategoriaProdutoViewModel : BaseEntity
    {
        public string Nome { get; set; }
    }
}
