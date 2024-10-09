using AutoMapper;
using PetCareConnect.App.ViewModels;
using PetCareConnect.Business.Models;

namespace PetCareConnect.App.AutoMapper
{
    public class ConfigAutoMapper : Profile
    {
        public ConfigAutoMapper() 
        {
            CreateMap<Cliente, ClienteViewModel>().ReverseMap();
            CreateMap<Comprador, CompradorViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<EnderecoComprador, EnderecoCompradorViewModel>().ReverseMap();
            CreateMap<EnderecoPrestador, EnderecoPrestadorViewModel>().ReverseMap();
            CreateMap<Freelancer, FreelancerViewModel>().ReverseMap();

            CreateMap<Prestador, PrestadorViewModel>().ReverseMap();

            CreateMap<Servico, ServicoViewModel>().ReverseMap();

            CreateMap<Produto, ProdutoViewModel>().ReverseMap();

            CreateMap<Vendedor, VendedorViewModel>().ReverseMap();
            CreateMap<Pet, PetViewModel>().ReverseMap();
            CreateMap<CategoriaProduto, CategoriaProdutoViewModel>().ReverseMap();
            
        }   
    }
}
