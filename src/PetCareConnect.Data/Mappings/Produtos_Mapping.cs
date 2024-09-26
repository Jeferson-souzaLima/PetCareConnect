using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetCareConnect.Business.Models;

namespace PetCareConnect.Data.Mappings 
{ 
    public class Produtos_Mapping : IEntityTypeConfiguration<Produtos>
    {
        public void Configure(EntityTypeBuilder<Produtos> builder)
        {
            builder.HasKey(p => p.ProdutoId);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Descricao)
                .IsRequired()
                .HasColumnType("varchar(max)");
            
            builder.Property(p => p.Valor)
                .IsRequired()
                .HasColumnType("varchar(100)");
            
            builder.Property(p => p.Disponivel)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(c => c.Imagem)
                .HasColumnType("varchar(100)");

            //Relacionamento N p/ 1 
            builder.HasOne(p => p.Vendedor)
                .WithMany(pr => pr.Produtos);
                
                //Relacionamento N p/ 1 
            builder.HasOne(p => p.PetShop)
                .WithMany(pr => pr.Produtos);

            //Relacionamento N p/ 1 
            builder.HasOne(p => p.Pedidos)
                .WithMany(pr => pr.Produtos);

            builder.ToTable("TB_PRODUTOS"); ;
        }

    }

    public class CategoriaProdutos_Mapping : IEntityTypeConfiguration<CategoriaProdutos>
    {
        public void Configure(EntityTypeBuilder<CategoriaProdutos> builder)
        {
            builder.HasKey(p => p.CategoriaId); 
            
            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.ToTable("TB_CategoriaProdutos");
        }
    }
}
