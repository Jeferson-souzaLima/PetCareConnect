using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetCareConnect.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareConnect.Data.Mappings
{
    public class ServicoMapping : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {

            builder.Property(s => s.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(s => s.Descricao)
                .IsRequired()
                .HasColumnType("varchar(1000)");

            builder.Property(s => s.Valor)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.ToTable("TB_SERVICO");

        }
    }
}
