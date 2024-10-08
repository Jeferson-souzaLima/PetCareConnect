using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetCareConnect.Business.Models;

namespace PetCareConnect.Data.Mappings
{
    public class PetMapping : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {

            builder.Property(f => f.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");
            
            builder.Property(f => f.Raca)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(f => f.Porte)
                .HasColumnType("varchar(10)");

            builder.Property(c => c.Imagem)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.ToTable("TB_PET");

        }
    }
}

