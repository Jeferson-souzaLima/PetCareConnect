using Microsoft.EntityFrameworkCore;
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

        public async Task<Prestador> ObterPorIdComEndereco(Guid id)
        {
            var prestador = await Db.Prestadores
                .Include(t => t.Endereco)
                  .SingleOrDefaultAsync(m => m.Id == id);

            return prestador;
        }
    }
}
