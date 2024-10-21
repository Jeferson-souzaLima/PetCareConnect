using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetCareConnect.Business.Models;
using PetCareConnect.App.ViewModels;

namespace PetCareConnect.App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<PetCareConnect.App.ViewModels.ProdutoViewModel> ProdutoViewModel { get; set; }
        public DbSet<PetCareConnect.App.ViewModels.ServicoViewModel> ServicoViewModel { get; set; }
        
    }
}
