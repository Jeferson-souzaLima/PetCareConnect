using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetCareConnect.Business.Models;

namespace PetCareConnect.Data.Mappings
{
    public class Vendedor_Mapping : IEntityTypeConfiguration<Vendedor>
    {
        public void Configure(EntityTypeBuilder<Vendedor> builder)
        {
            builder.HasKey(v => v.PrestadorId);

            builder.Property(v => v.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(v => v.Documento)
                .IsRequired()
                .HasColumnType("varchar(14)");

            //Relacionamento 1 p/ 1 
            builder.HasOne(e => e.Endereco)
                .WithOne(c => c.Vendedor);

            builder.Property(c => c.Imagem)
                .HasColumnType("varchar(100)");

            //Relacionamento 1 p/N 
            builder.HasMany(c => c.Produtos)
                .WithOne(g => g.Vendedor)
                .HasForeignKey(propa => propa.ProdutoId);

            builder.ToTable("TB_VENDEDOR");
        }
    }

    public class Freelancer_Mapping : IEntityTypeConfiguration<Freelancer>
    {
        public void Configure(EntityTypeBuilder<Freelancer> builder)
        {
            builder.HasKey(v => v.PrestadorId);

            builder.Property(v => v.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(v => v.Documento)
                .IsRequired()
                .HasColumnType("varchar(14)");

            //Relacionamento 1 p/ 1 
            builder.HasOne(e => e.Endereco)
                .WithOne(c => c.Freelancer);

            builder.Property(c => c.Imagem)
                .HasColumnType("varchar(100)");

            //Relacionamento 1 p/N 
            builder.HasMany(c => c.Servicos)
                .WithOne(g => g.Freelancer)
                .HasForeignKey(propa => propa.ServicoId);

            builder.ToTable("TB_FREELANCER");
        }
    }

    public class PetShop_Mapping : IEntityTypeConfiguration<PetShop>
    {
        public void Configure(EntityTypeBuilder<PetShop> builder)
        {
            builder.HasKey(v => v.PrestadorId);

            builder.Property(v => v.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(v => v.Documento)
                .IsRequired()
                .HasColumnType("varchar(14)");

            //Relacionamento 1 p/ 1 
            builder.HasOne(e => e.Endereco)
                .WithOne(c => c.PetShop);

            builder.Property(c => c.Imagem)
                .HasColumnType("varchar(100)");

            //Relacionamento 1 p/N 
            builder.HasMany(c => c.Servicos)
                .WithOne(g => g.PetShop)
                .HasForeignKey(propa => propa.ServicoId);
            
            //Relacionamento 1 p/N 
            builder.HasMany(c => c.Produtos)
                .WithOne(g => g.PetShop)
                .HasForeignKey(propa => propa.ProdutoId);

            builder.ToTable("TB_PETSHOP");
        }
    }
}
