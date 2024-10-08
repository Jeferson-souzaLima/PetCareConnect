using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetCareConnect.Business.Models;

namespace PetCareConnect.Data.Mappings
{
    public class CompradorMapping : IEntityTypeConfiguration<Comprador>
    {
        public void Configure(EntityTypeBuilder<Comprador> builder)
        {
            //Relacionamento 1 p/N
            builder.HasMany(c => c.Pets)
               .WithOne(e => e.Comprador)
               .IsRequired()
               .OnDelete(DeleteBehavior.Cascade);//APAGA EM CASCATA

            builder.Property(c => c.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(c => c.Documento)
                .HasColumnType("varchar(14)")
                .IsRequired();

            builder.Property(c => c.Imagem)
                .IsRequired()
                .HasColumnType("varchar(100)");

            //Relacionamento 1 p/ 1 
            builder.HasOne(c => c.Endereco)
                .WithOne(c => c.Comprador)
                .HasForeignKey("EnderecoComprador", "CompradorId");

            builder.ToTable("TB_COMPRADOR");
        }
    }
}

