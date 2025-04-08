using Atlantic.Examen.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantic.Examen.Domain.Entities
{
    public class Libro: BaseEntity
    {
        public required string Titulo { get; set; }
        public required string Autor { get; set; }
        public decimal PrecioAlquiler { get; set; }
        public decimal PrecioVenta { get; set; }
        public Guid CodigoQR { get; set; }
        public int CantidadCopias { get; set; }
        public int CopiasDisponibles { get; set; }

        public Alquiler Alquilar(Cliente cliente, decimal precio)
        {
            if (CopiasDisponibles <= 0)
                throw new LibroNoDisponibleException("No hay copias disponibles");
            CopiasDisponibles -= 1;
            return Alquiler.CrearNuevo(cliente, this, precio);
        }
    }
}
