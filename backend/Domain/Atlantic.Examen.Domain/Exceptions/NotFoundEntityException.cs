﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantic.Examen.Domain.Exceptions
{
    public class NotFoundEntityException : BaseException
    {
        public NotFoundEntityException(string entityName)
            : base($"'{entityName}' no encontrada")
        {
            Codigo = 40401;
        }
    }
}
