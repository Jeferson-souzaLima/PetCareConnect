using PetCareConnect.Business.Interfaces;
using PetCareConnect.Business.Models;
using PetCareConnect.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareConnect.Data.Repositories
{
    public class PrestadorRepository : BaseRepository<Prestador>, IPrestadorRepository
    {
        public PrestadorRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }
    }
}
