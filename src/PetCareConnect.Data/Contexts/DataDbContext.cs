using Microsoft.EntityFrameworkCore;
using PetCareConnect.Business.Models;

namespace PetCareConnect.Data.Contexts
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<GrupoPedidos> GrupoPedidos { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<Prestador> Prestador { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Servicos> Servicos { get; set; }
        public DbSet<CategoriaProdutos> CategoriaProdutos { get; set; }
        public DbSet<Pets> Pets { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configurar os campos do tipo string, caso não sejam mapeados
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            //Informar qual será o contexto utilizado
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataDbContext).Assembly);

            //Configurar para que não haja exclusão em cascata no banco de dados
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }
    }
}
