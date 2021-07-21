using CrudUsuario.Application.DTOs;
using CrudUsuario.Application.Interfaces;
using CrudUsuario.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrudUsuario.Application.Services
{
    public class UsuarioAppService : IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioAppService(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public IEnumerable<UsuarioDTO> GetUsuarios()
        {
            var usuarios = _usuarioService.GetAll();
            var resultado = usuarios.Select(u => new UsuarioDTO(u));
            return resultado;
        }
    }
}
