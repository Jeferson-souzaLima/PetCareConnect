using PetCareConnect.Business.Interfaces;
using PetCareConnect.Business.Models;
using PetCareConnect.Data.Contexts;

namespace PetCareConnect.Data.Repositories
{
    public class PrestadorRepository : BaseRepository<Prestador>, IPrestadorRepository
    {
        public PrestadorRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }

        Task IPrestadorRepository.Adicionar(Servico prestador)
        {
            throw new NotImplementedException();
        }
    }
}
