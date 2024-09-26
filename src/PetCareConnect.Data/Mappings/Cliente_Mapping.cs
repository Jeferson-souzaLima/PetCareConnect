using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetCareConnect.Business.Models;

namespace PetCareConnect.Data.Mappings
{
    public class Cliente_Mapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.ClienteId);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(c => c.Documento)
                .IsRequired()
                .HasColumnType("varchar(14)");

            //Relacionamento 1 p/ 1 
            builder.HasOne(c => c.Endereco)
                .WithOne(e => e.Cliente);

            //Relacionamento 1 p/N
            builder.HasMany(c => c.Pedidos)
               .WithOne(p => p.Cliente)
               .HasForeignKey(propa => propa.PedidoId);

            //Relacionamento 1 p/N 
            builder.HasMany(c => c.GrupoPedidos)
                .WithOne(g => g.Cliente)
                .HasForeignKey(propa => propa.GrupoPedidoId);

            builder.Property(c => c.Imagem)
                .HasColumnType("varchar(100)");

            //Relacionamento 1 p/N 
            builder.HasMany(c => c.Pets)
                .WithOne(pet => pet.Cliente)
                .HasForeignKey(propa => propa.PetId);

            builder.ToTable("TB_CLIENTE"); ;
        }

        public class Pets_Mapping : IEntityTypeConfiguration<Pets>
        {
            public void Configure(EntityTypeBuilder<Pets> builder)
            {
                builder.HasKey(pet => pet.PetId);

                //Relacionamento 1 p/ 1 
                builder.HasOne(pet => pet.Cliente)
                    .WithMany(c => c.Pets);

                builder.Property(pet => pet.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

                builder.Property(pet => pet.Idade)
                .IsRequired()
                .HasColumnType("varchar(100)");

                builder.Property(pet => pet.Imagem)
                .HasColumnType("varchar(100)");

                builder.ToTable("TB_PETS"); ;
            }
        }
    }
}
