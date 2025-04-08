using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantic.Examen.Domain.Exceptions
{
    public class LibroNoDisponibleException(string message): BaseException(40020, message)
    {
    }
}
