using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetCareConnect.Business.Models;

namespace PetCareConnect.Data.Mappings
{
    public class GrupoPedidos_Mapping : IEntityTypeConfiguration<GrupoPedidos>
    {
        public void Configure(EntityTypeBuilder<GrupoPedidos> builder)
        {
            builder.HasKey(g => g.GrupoPedidoId);

            //Relacionamento 1 p/N
            builder.HasMany(g => g.Pedidos)
               .WithOne(p => p.GrupoPedidos)
               .HasForeignKey(propa => propa.PedidoId);

            //Relacionamento 1 p/ 1 
            builder.HasOne(g => g.Cliente)
                .WithMany(c => c.GrupoPedidos);

            builder.Property(g => g.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.ToTable("TB_GRUPOPEDIDOS"); ;
        }
    }
}
