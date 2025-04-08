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
    public class LibroConfig : IEntityTypeConfiguration<Libro>
    {
        public void Configure(EntityTypeBuilder<Libro> builder)
        {
            builder.EntityConfig();
            builder.Property(c => c.PrecioAlquiler)
                .HasPrecision(18, 4);
            builder.Property(c => c.PrecioVenta)
                .HasPrecision(18, 4);
        }
    }
}
