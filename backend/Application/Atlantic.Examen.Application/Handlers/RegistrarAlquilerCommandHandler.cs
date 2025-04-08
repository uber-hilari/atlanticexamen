using Atlantic.Examen.Application.Commands;
using Atlantic.Examen.Domain.Entities;
using Atlantic.Examen.Domain.Exceptions;
using Atlantic.Examen.Domain.Services;
using Atlantic.Examen.Domain.Specifications;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantic.Examen.Application.Handlers
{
    public class RegistrarAlquilerCommandHandler(
        IDataReader dataReader,
        IDataWriter dataWriter
    ) : IRequestHandler<RegistrarAlquilerCommand>
    {
        public async Task Handle(RegistrarAlquilerCommand request, CancellationToken cancellationToken)
        {
            var cliente = await dataReader.Get<Cliente>(request.Data.IdCliente);
            if (cliente.EnListaNegra)
            {
                throw new ClienteEnBlackListException();
            }

            var libro = await dataReader.GetOrNull(LibroSpecifications.Disponible(request.Data.QrLibro).ToExpression());
            if (libro == null)
            {
                throw new LibroNoDisponibleException("No hay copias disponibles");
            }

            var alquiler = libro.Alquilar(cliente, request.Data.Precio);

            await dataWriter.Agregar(alquiler);
        }
    }
}
