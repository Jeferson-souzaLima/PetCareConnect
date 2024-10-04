using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetCareConnect.Business.Models;

namespace PetCareConnect.Data.Mappings
{
    public class FreelancerMapping : IEntityTypeConfiguration<Freelancer>
    {
        public void Configure(EntityTypeBuilder<Freelancer> builder)
        {

            builder.Property(f => f.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(f => f.Documento)
                .HasColumnType("varchar(14)")
                .IsRequired();

            builder.Property(f => f.Imagem)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(f => f.TipoPrestador)
                .HasColumnType("varchar(10)");

            builder.HasOne(f => f.EnderecoFreelancer)
                .WithOne(e => e.Freelancer)
                .HasForeignKey("FreelancerId");
        }
    }

    public class EnderecoFrellancerMapping : IEntityTypeConfiguration<EnderecoFreelancer>
    {
        public void Configure(EntityTypeBuilder<EnderecoFreelancer> builder)
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

            builder.ToTable("TB_ENDERECO_FREELANCER");
        }
    }
}
