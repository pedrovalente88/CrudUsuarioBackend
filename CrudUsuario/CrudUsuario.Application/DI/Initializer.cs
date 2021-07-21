using CrudUsuario.Domain.Entities;
using CrudUsuario.Domain.Interfaces.Repositories;
using CrudUsuario.Domain.Interfaces.Services;
using CrudUsuario.Domain.Services;
using CrudUsuario.Infra.Context;
using CrudUsuario.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudUsuario.Application.DI
{
    public class Initializer
    {
        public static void Configure(IServiceCollection services, string conection)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(conection));
        }

        
    }
}
