using Atlantic.Examen.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantic.Examen.Domain.Entities
{
    public class Cliente : BaseEntity
    {
        public required string Nombres { get; set; }
        public required string Apellidos { get; set; }
        public TipoDocumentoIdentidad TipoDocumento { get; set; }
        public required string NumeroDocumento { get; set; }
        public required string Telefono { get; set; }
        public required string Email { get; set; }
        public string Dirección { get; set; } = string.Empty;
        public string Ubigeo { get; set; } = string.Empty;
        public bool EnListaNegra { get; set; }
    }
}
