using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetCareConnect.Business.Models;

namespace PetCareConnect.Data.Mappings
{
    public class Endereco_Mapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.EnderecoId);

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

            //Relacionamento 1 p/ 1 
            builder.HasOne(e => e.Cliente)
                .WithOne(c => c.Endereco);

            //Relacionamento 1 p/ 1 
            builder.HasOne(e => e.Vendedor)
                .WithOne(pi => pi.Endereco);
            
            //Relacionamento 1 p/ 1 
            builder.HasOne(e => e.Freelancer)
                .WithOne(pi => pi.Endereco);
            
            //Relacionamento 1 p/ 1 
            builder.HasOne(e => e.PetShop)
                .WithOne(pi => pi.Endereco);

            builder.ToTable("TB_ENDERECO");
        }
    }
}
