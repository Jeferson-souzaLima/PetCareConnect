using PetCareConnect.Business.Interfaces;
using PetCareConnect.Business.Models;
using PetCareConnect.Business.Validations;

namespace PetCareConnect.Business.Services
{
    public class PrestadorService : BaseService, IPrestadorService
    {
        private readonly IPrestadorRepository prestadorRepository;

        public PrestadorService(IPrestadorRepository prestadorRepository, INotificador notificador) : base(notificador)
        {
            this.prestadorRepository = prestadorRepository;
        }
        public async Task Adicionar(Prestador prestador)
        {
            if (!ExecutarValidacao(new PrestadorValidation(), prestador)) return;
            await this.prestadorRepository.Adicionar(prestador);
        }

        public async Task Alterar(Prestador prestador)
        {
            if (!ExecutarValidacao(new PrestadorValidation(), prestador)) return;
            await this.prestadorRepository.Alterar(prestador);
        }

        public void Dispose()
        {
            this.prestadorRepository.Dispose();
        }

        public async Task Remover(Guid id)
        {
            await this.prestadorRepository.Remover(id);
        }
    }
}
