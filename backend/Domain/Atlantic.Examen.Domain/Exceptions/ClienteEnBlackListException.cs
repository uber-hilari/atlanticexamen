using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantic.Examen.Domain.Exceptions
{
    public class ClienteEnBlackListException() : BaseException(40010, "El cliente se encuentra en la BlackList")
    {
    }
}
