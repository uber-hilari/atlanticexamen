using Atlantic.Examen.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantic.Examen.DataAccess.Configs
{
    public class AlquilerConfig : IEntityTypeConfiguration<Alquiler>
    {
        public void Configure(EntityTypeBuilder<Alquiler> builder)
        {
            builder.EntityConfig();
            builder.Property(c => c.Precio)
                .HasPrecision(18, 4);
            builder.HasOne(c => c.Libro)
                .WithMany()
                .HasForeignKey("IdLibro");
            builder.HasOne(c => c.Cliente)
                .WithMany()
                .HasForeignKey("IdCliente");
        }
    }
}
