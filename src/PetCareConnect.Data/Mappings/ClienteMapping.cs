using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetCareConnect.Business.Models;

namespace PetCareConnect.Data.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {

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
            builder.HasOne(c => c.EnderecoCliente)
                .WithOne()
                .HasForeignKey("ClienteId");

            //Relacionamento 1 p/N
            builder.HasMany(c => c.Pet)
               .WithOne(e => e.Cliente);
              
            builder.ToTable("TB_CLIENTE");
        }
    }

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

            //Relacionamento 1 p/N
            builder.HasOne(f => f.Cliente)
               .WithMany(e => e.Pet);
         
        }
    }

    public class EnderecoClienteMapping : IEntityTypeConfiguration<EnderecoCliente>
    {
        public void Configure(EntityTypeBuilder<EnderecoCliente> builder)
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

            builder.ToTable("TB_ENDERECO_CLIENTE");
        }
    }
}

