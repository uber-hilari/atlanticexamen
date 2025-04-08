using Atlantic.Examen.Domain.Entities;
using Atlantic.Examen.Domain.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantic.Examen.DataAccess
{
    public class DataWriter(AppDbContext context) 
        : IDataWriter
    {
        public Task Agregar<TEntity>(TEntity entity) where TEntity : BaseEntity => Task.Run(() =>
        {
            context.Set<TEntity>().Add(entity);
        });

        public Task Grabar()
        {
            return context.SaveChangesAsync();
        }
    }
}
