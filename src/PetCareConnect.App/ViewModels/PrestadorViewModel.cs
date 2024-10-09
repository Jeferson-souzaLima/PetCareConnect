using PetCareConnect.App.ViewModels;
using PetCareConnect.Business.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareConnect.Business.Models
{
    public abstract class PrestadorViewModel : ClienteViewModel
    {
        public TipoPrestador TipoPrestador { get; set; }
        public EnderecoPrestadorViewModel Endereco { get; set; }
    }

    public class EnderecoPrestadorViewModel : EnderecoViewModel
    {
        public PrestadorViewModel Prestador { get; set; }

    }
    

}
