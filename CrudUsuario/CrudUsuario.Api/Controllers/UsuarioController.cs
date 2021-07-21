using CrudUsuario.Application.DTOs;
using CrudUsuario.Application.Interfaces;
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
        private readonly IUsuarioAppService _usuarioAppService;

        public UsuarioController(IUsuarioAppService usuarioAppService)
        {
            _usuarioAppService = usuarioAppService;
        }

        [HttpGet]
        [Route("GetUsuarios")]
        public IEnumerable<UsuarioDTO> GetUsuarios()
        {
            return _usuarioAppService.GetUsuarios();
        }
    }
}
