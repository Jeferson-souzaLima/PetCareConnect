using PetCareConnect.Business.Models;

namespace PetCareConnect.Business.Interfaces
{
    interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);
        Task Alterar(Produto produto);
        Task Remover(Guid id);
    }
}
