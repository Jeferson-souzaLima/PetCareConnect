using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetCareConnect.Business.Models;

namespace PetCareConnect.Data.Mappings
{
    public class Pedidos_Mapping : IEntityTypeConfiguration<Pedidos>
    {
        public void Configure(EntityTypeBuilder<Pedidos> builder)
        {
            builder.HasKey(p => p.PedidoId);

            builder.HasMany(p => p.Produtos)
                   .WithOne(pi => pi.Pedidos)
                   .HasForeignKey(propa => propa.ProdutoId);

            builder.HasMany(p => p.Servicos)
                   .WithOne(s => s.Pedidos)
                   .HasForeignKey(propa => propa.ServicoId);

            builder.HasOne(p => p.Cliente)
                  .WithMany(c => c.Pedidos);

           builder.HasOne(p => p.GrupoPedidos)
                   .WithMany(c => c.Pedidos);

            builder.ToTable("TB_PEDIDOS");
        }
    }
}
