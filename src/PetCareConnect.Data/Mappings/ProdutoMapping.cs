using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetCareConnect.Business.Models;

namespace PetCareConnect.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnName("varchar(200)");

            builder.Property(p => p.Descricao)
                .IsRequired()
                .HasColumnName("varchar(1000)");

            builder.Property(p => p.Imagem)
                .IsRequired()
                .HasColumnName("varchar(100)");

            builder.Property(p => p.Valor)
                .IsRequired()
                .HasColumnName("varchar(100)");
        }
    }

    public class CategoriaProdutoMapping : IEntityTypeConfiguration<CategoriaProduto>
    {
        public void Configure(EntityTypeBuilder<CategoriaProduto> builder)
        {

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnName("varchar(100)");
        }
    }
}
