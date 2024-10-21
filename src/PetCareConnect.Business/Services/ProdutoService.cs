using PetCareConnect.Business.Interfaces;
using PetCareConnect.Business.Models;
using PetCareConnect.Business.Validations;

namespace PetCareConnect.Business.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        private readonly IProdutoRepository produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository, INotificador notificador): base(notificador) 
        {
            this.produtoRepository = produtoRepository;
        }
        public async Task Adicionar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(),produto))return;
            await this.produtoRepository.Adicionar(produto);
        }

        public async Task Alterar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(),produto))return;
            await this.produtoRepository.Alterar(produto);
        }

        public void Dispose()
        {
             this.produtoRepository.Dispose();
        }

        public async Task Remover(Guid id)
        {
            await this.produtoRepository.Remover(id);
        }
    }
}
