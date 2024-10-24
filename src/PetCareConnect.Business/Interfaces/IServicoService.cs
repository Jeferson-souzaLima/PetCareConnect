using PetCareConnect.Business.Models;

namespace PetCareConnect.Business.Interfaces
{
    public interface IServicoService : IDisposable
    {
        Task Adicionar(Servico servico);
        Task Alterar(Servico servico);
        Task Remover(Guid id);
        
    }
}
