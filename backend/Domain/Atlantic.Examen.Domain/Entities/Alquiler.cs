using Atlantic.Examen.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantic.Examen.Domain.Entities
{
    public class Alquiler: BaseEntity
    {
        public required virtual Libro Libro { get; set; }
        public required virtual Cliente Cliente { get; set; }
        public DateTime FechaAlquiler { get; set; }
        public DateTime? FechaRetorno { get; set; }
        public decimal Precio { get; set; }
        public EstadoLibro EstadoLibro { get; set; }
        public EstadoAlquiler EstadoAlquiler { get; set; }

        public static Alquiler CrearNuevo(Cliente cliente, Libro libro, decimal precio) =>
            new Alquiler
            {
                Cliente = cliente,
                Libro = libro,
                Precio = precio,
                EstadoAlquiler = EstadoAlquiler.EnProceso,
                EstadoLibro = EstadoLibro.Normal,
                FechaAlquiler = DateTime.UtcNow
            };
    }
}
