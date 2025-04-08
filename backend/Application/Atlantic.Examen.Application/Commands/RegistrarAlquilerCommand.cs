using Atlantic.Examen.Models.Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantic.Examen.Application.Commands
{
    public record RegistrarAlquilerCommand : IRequest
    {
        public required RegistrarAlquilerRq Data { get; set; }
    }
}
