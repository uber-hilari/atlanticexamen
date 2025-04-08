using Atlantic.Examen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantic.Examen.Domain.Specifications
{
    public static class LibroSpecifications
    {
        public static Specification<Libro> Disponible(Guid qr) =>
            new ExprSpecification<Libro>(c => c.CodigoQR == qr && c.CopiasDisponibles > 0);
    }
}
