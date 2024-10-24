using PetCareConnect.Business.Interfaces;
using PetCareConnect.Business.Models;
using PetCareConnect.Business.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareConnect.Business.Services
{
    internal class PrestadorService
    {
        private readonly IPrestadorRepository prestadorRepository;

        public PrestadorService(IPrestadorRepository prestadorRepository, INotificador notificador) : base(notificador)
        {
            this.prestadorRepository = prestadorRepository;
        }
        public async Task Adicionar(Prestador prestador)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), prestador)) return;
            await this.prestadorRepository.Adicionar(prestador);
        }

        public async Task Alterar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), prestador)) return;
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
