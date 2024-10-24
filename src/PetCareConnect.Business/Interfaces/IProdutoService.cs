using PetCareConnect.Business.Models;

namespace PetCareConnect.Business.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);
        Task Alterar(Produto produto);
        Task Remover(Guid id);
    }
}
