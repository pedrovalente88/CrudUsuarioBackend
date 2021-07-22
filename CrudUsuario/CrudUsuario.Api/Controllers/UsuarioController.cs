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

        [HttpGet]
        [Route("GetUsuarioById")]
        public UsuarioDTO GetUsuarioById(long id)
        {
            return _usuarioAppService.GetUsuarioById(id);
        }

        [HttpPost]
        [Route("Criar")]
        public ActionResult<RetornoPadraoDTO> Criar([FromBody] UsuarioDTO usuarioDTO)
        {
            return _usuarioAppService.Criar(usuarioDTO);
        }

        [HttpPut]
        [Route("Editar")]
        public ActionResult<RetornoPadraoDTO> Editar([FromBody] UsuarioDTO usuarioDTO)
        {
            return _usuarioAppService.Editar(usuarioDTO);
        }

        [HttpDelete]     
        [Route("Deletar")]
        public ActionResult<RetornoPadraoDTO> Deletar([FromQuery] long id)
        {
            return _usuarioAppService.Deletar(id);
        }
    }
}
