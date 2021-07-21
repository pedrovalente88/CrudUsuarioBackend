using CrudUsuario.Domain.Entities;
using CrudUsuario.Domain.Interfaces.Repositories;
using CrudUsuario.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudUsuario.Infra.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(AppDbContext context) : base(context)
        { }
    }
}
