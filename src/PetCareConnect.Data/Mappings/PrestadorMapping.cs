using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PetCareConnect.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetCareConnect.Business.Enums;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace PetCareConnect.Data.Mappings
{
    public class PrestadorMapping : IEntityTypeConfiguration<Prestador>
    {
        public void Configure(EntityTypeBuilder<Prestador> builder)
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
            builder.HasOne(c => c.Endereco)
                .WithOne(c => c.Prestador)
                .HasForeignKey("EnderecoPrestador", "PrestadorId");

            builder.HasDiscriminator<TipoPrestador>("TipoPrestador")

            .HasValue<PetShop>(TipoPrestador.PetShop)

            .HasValue<Vendedor>(TipoPrestador.Vendedor)

            .HasValue<Freelancer>(TipoPrestador.Freelancer);

            builder.Property(e => e.TipoPrestador)
                .HasColumnType("varchar(100)");

            builder.ToTable("TB_PRESTADOR");

            //.Property("Discriminator")
            //    .HasMaxLength(200);

        }
    }

    //public class VendedorMapping : IEntityTypeConfiguration<Vendedor>
    //{
    //    public void Configure(EntityTypeBuilder<Vendedor> builder)
    //    {
    //        builder.ToTable("TB_VENDEDOR");
    //    }
    //}
    //public class PetShopMapping : IEntityTypeConfiguration<PetShop>
    //{
    //    public void Configure(EntityTypeBuilder<PetShop> builder)
    //    {
    //        builder.ToTable("TB_PETSHOP");
    //    }
    //}
    //public class FreelancerMapping : IEntityTypeConfiguration<Freelancer>
    //{
    //    public void Configure(EntityTypeBuilder<Freelancer> builder)
    //    {
    //        builder.ToTable("TB_FREELANCER");
    //    }
    //}
}

