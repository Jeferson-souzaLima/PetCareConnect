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
                .HasColumnName("varchar(100)");

            builder.Property(s => s.Descricao)
                .IsRequired()
                .HasColumnName("varchar(1000)");

            builder.Property(s => s.Valor)
                .IsRequired()
                .HasColumnName("varchar(30)");
        }
    }
}
