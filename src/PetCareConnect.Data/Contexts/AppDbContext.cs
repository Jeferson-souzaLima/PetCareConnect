using Microsoft.EntityFrameworkCore;
using PetCareConnect.Business.Models;

namespace PetCareConnect.Data.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        //public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Prestador> Prestadores { get; set; }
        public DbSet<Comprador> Compradores { get; set; }
        public DbSet<Pet> Pets { get; set; }
        //public DbSet<Endereco> Enderecos { get; set; }
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
            //foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                //relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            modelBuilder.Entity<EnderecoPrestador>().ToTable("TB_ENDERECO_PRESTADOR");
            modelBuilder.Entity<EnderecoComprador>().ToTable("TB_ENDERECO_COMPRADOR");

            base.OnModelCreating(modelBuilder);
        }
    }
}
