using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareConnect.Business.Models
{
    public class Servico : BaseEntity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        //public Servico(string nome, string descricao, decimal valor) 
        //{
        //    Nome = nome;
        //    Descricao = descricao;
        //    Valor = valor;
        //}

        //public Servico()
        //{
        //}
    }
}
