using Microsoft.EntityFrameworkCore;
using PetCareConnect.Business.Models;

namespace PetCareConnect.Data.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<BaseEntity> BaseEntity { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pet> Pet { get; set; }
        public DbSet<EnderecoVendedor> EnderecoVendedor { get; set; }
        public DbSet<EnderecoFreelancer> EnderecoFreelancer { get; set; }
        public DbSet<EnderecoCliente> EnderecoCliente { get; set; }
        public DbSet<Freelancer> Freelancer { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<CategoriaProduto> CategoriaProduto { get; set; }
        public DbSet<Servico> Servico { get; set; }
        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configurar os campos do tipo string, caso não sejam mapeados
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            //Informar qual será o contexto utilizado
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            //Configurar para que não haja exclusão em cascata no banco de dados
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }
    }
}
