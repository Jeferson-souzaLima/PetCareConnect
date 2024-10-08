using AutoMapper;
using PetCareConnect.Business.Models;
//using PetCareConnect.App.ViewModels;
//using PetCareConnect.Business.Models;


namespace PetCareConnect.App.AutoMapper
{
    public class ConfigAutoMapper : Profile
    {
        public ConfigAutoMapper() 
        {
            CreateMap<Cliente, ClienteViewModel>().ReverseMap();
            //CreateMap<EnderecoCliente, EnderecoClienteViewModel>().ReverseMap();

            CreateMap<Freelancer, FreelancerViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoFreelancerViewModel>().ReverseMap();

            CreateMap<Vendedor, VendedorViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoVendedorViewModel>().ReverseMap(); 
            
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
            CreateMap<CategoriaProduto, CategoriaProdutoViewModel>().ReverseMap();

            CreateMap<Servico, ServicoViewModel>().ReverseMap();

            CreateMap<Pet, PetViewModel>().ReverseMap();
        }   
    }
}
