using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetCareConnect.Business.Models;

namespace PetCareConnect.App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<PetCareConnect.Business.Models.ProdutoViewModel> ProdutoViewModel { get; set; }
        public DbSet<PetCareConnect.Business.Models.ServicoViewModel> ServicoViewModel { get; set; }
        
    }
}
