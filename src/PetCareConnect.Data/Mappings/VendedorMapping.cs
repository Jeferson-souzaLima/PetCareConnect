using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetCareConnect.Business.Models;

namespace PetCareConnect.Data.Mappings
{
    public class VendedorMapping : IEntityTypeConfiguration<Vendedor>
    {
        public void Configure(EntityTypeBuilder<Vendedor> builder)
        {

            builder.Property(v => v.Nome)
                .IsRequired()
                .HasColumnName("varchar(100)");
            
            builder.Property(v => v.Documento)
                .IsRequired()
                .HasColumnName("varchar(100)");
            
            builder.Property(v => v.Imagem)
                .HasColumnName("varchar(100)");
            
            builder.Property(v => v.TipoPrestador)
                .HasColumnName("varchar(100)");

            builder.HasOne(f => f.EnderecoVendedor)
                .WithOne(e => e.Vendedor)
                .HasForeignKey("FreelancerId");

            builder.ToTable("TB_VENDEDOR");
        }
    }

    public class EnderecoVendedorMapping : IEntityTypeConfiguration<EnderecoVendedor>
    {
        public void Configure(EntityTypeBuilder<EnderecoVendedor> builder)
        {

            builder.Property(e => e.Cep)
                .IsRequired()
                .HasColumnType("varchar(8)");

            builder.Property(e => e.Estado)
                .IsRequired()
                .HasColumnType("varchar(150)");

            builder.Property(e => e.Bairro)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(e => e.Cidade)
                .IsRequired()
                .HasColumnType("varchar(150)");

            builder.Property(e => e.Logradouro)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.ToTable("TB_ENDERECO_VENDEDOR");
        }
    }
}
