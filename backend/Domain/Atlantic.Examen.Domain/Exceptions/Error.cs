using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantic.Examen.Domain.Exceptions
{
    public class Error(int codigo, string mensaje)
    {
        public int Codigo { get; } = codigo;
        public string Mensaje { get; } = mensaje;
    }
}
