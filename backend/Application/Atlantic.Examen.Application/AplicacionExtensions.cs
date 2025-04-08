using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantic.Examen.Application
{
    public static class AplicacionExtensions
    {
        public static MediatRServiceConfiguration AgregarAplicacion(this MediatRServiceConfiguration config)
        {
            config.AddOpenBehavior(typeof(ValidationPipeline<,>));
            config.RegisterServicesFromAssembly(typeof(AplicacionExtensions).Assembly);
            return config;
        }

        public static IServiceCollection AgregarAplicacion(this IServiceCollection services)
        {

            services.AddValidatorsFromAssembly(typeof(AplicacionExtensions).Assembly);

            return services;
        }
    }
}
