using Atlantic.Examen.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantic.Examen.DataAccess.Configs
{
    public static class BaseEntityConfig
    {
        public static EntityTypeBuilder<T> EntityConfig<T>(this EntityTypeBuilder<T> entity) where T : BaseEntity
        {
            entity.HasQueryFilter(c => c.Eliminado == false);
            entity.Property(c => c.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
            return entity;
        }
    }
}
