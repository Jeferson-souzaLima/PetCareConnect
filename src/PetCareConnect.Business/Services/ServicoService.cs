using PetCareConnect.Business.Interfaces;
using PetCareConnect.Business.Models;
using PetCareConnect.Business.Validations;

namespace PetCareConnect.Business.Services
{
    public class ServicoService : BaseService, IServicoService
    {
        private readonly IServicoRepository servicoRepository;

        public ServicoService(IServicoRepository servicoRepository, INotificador notificador) : base(notificador)
        {
            this.servicoRepository = servicoRepository;
        }
        public async Task Adicionar(Servico servico)
        {
            if (!ExecutarValidacao(new ServicoValidation(), servico)) return;
            await this.servicoRepository.Adicionar(servico);
        }

        public async Task Alterar(Servico servico)
        {
            if (!ExecutarValidacao(new ServicoValidation(), servico)) return;
            await this.servicoRepository.Alterar(servico);
        }

        public void Dispose()
        {
            this.servicoRepository.Dispose();
        }

        public async Task Remover(Guid id)
        {
            await this.servicoRepository.Remover(id);
        }
    }
}
