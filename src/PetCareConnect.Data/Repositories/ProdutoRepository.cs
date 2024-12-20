﻿using PetCareConnect.Business.Interfaces;
using PetCareConnect.Business.Models;
using PetCareConnect.Data.Contexts;

namespace PetCareConnect.Data.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(AppDbContext appDbContext) : base (appDbContext)
        {
            
        }
    }

}
