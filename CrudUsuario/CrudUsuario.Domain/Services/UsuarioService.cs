using CrudUsuario.Domain.Entities;
using CrudUsuario.Domain.Interfaces.Repositories;
using CrudUsuario.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudUsuario.Domain.Services
{
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _UsuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
            : base(usuarioRepository)
        {
            _UsuarioRepository = usuarioRepository;
        }
    }
}
