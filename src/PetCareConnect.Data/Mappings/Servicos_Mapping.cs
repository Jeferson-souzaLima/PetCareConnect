using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetCareConnect.Business.Models;

namespace PetCareConnect.Data.Mappings
{
    public class Servicos_Mapping : IEntityTypeConfiguration<Servicos>
    {
        public void Configure(EntityTypeBuilder<Servicos> builder)
        {
            builder.HasKey(s => s.ServicoId);

            builder.Property(p => p.Nome)

                .HasColumnType("varchar(100)");

            builder.Property(p => p.Descricao)
                .IsRequired()
                .HasColumnType("varchar(100)");

            //Relacionamento 1 p/N
            builder.HasOne(s => s.PetShop)
               .WithMany(p => p.Servicos);
            
            //Relacionamento 1 p/N
            builder.HasOne(s => s.Freelancer)
               .WithMany(p => p.Servicos);
               
        }
    }
}
