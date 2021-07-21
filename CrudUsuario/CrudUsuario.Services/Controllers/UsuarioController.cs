using CrudUsuario.Api.DTOs;
using CrudUsuario.Domain.Interfaces.Services;
using CrudUsuario.Domain.Services;
using CrudUsuario.Infra.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudUsuario.Api.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        [Route("GetUsuarios")]
        public IEnumerable<UsuarioDTO> GetUsuarios()
        {
            var usuarios = _usuarioService.GetAll();
            var resultado = usuarios.Select(u => new UsuarioDTO(u));
            return resultado;
        }
    }
}
