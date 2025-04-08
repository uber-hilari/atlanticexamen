using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantic.Examen.Models.Requests
{
    public record RegistrarAlquilerRq
    {
        public Guid IdCliente { get; set; }
        public Guid QrLibro { get; set; }
        public decimal Precio { get; set; }
    }
}
