using CrudUsuario.Application.DTOs;
using CrudUsuario.Application.Interfaces;
using CrudUsuario.Domain.Interfaces.Services;
using CrudUsuario.Domain.Statics;
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
            var resultado = usuarios.Select(u => UsuarioDTO.Transformation(u));
            return resultado;
        }

        public UsuarioDTO GetUsuarioById(long id)
        {
            var usuario = _usuarioService.GetById(id);
            var resultado =  UsuarioDTO.Transformation(usuario);
            return resultado;
        }

        public RetornoPadraoDTO Criar(UsuarioDTO usuarioDTO)
        {
            try
            {
                var usuario = UsuarioDTO.Transformation(usuarioDTO);
                _usuarioService.Add(usuario);

                return new RetornoPadraoDTO("Usuário incluído com sucesso!", RetornoPadraoStatusStatic.Sucesso.Id);
            }
            catch (ArgumentException ex)
            {
                return new RetornoPadraoDTO(ex.Message, RetornoPadraoStatusStatic.Alerta.Id);
            }
            catch (Exception ex)
            {
                return new RetornoPadraoDTO(ex.Message, RetornoPadraoStatusStatic.Erro.Id);
            }
            
        }

        public RetornoPadraoDTO Editar(UsuarioDTO usuarioDTO)
        {
            try
            {
                var usuario = _usuarioService.GetById(usuarioDTO.id);

                if (usuario == null)
                    throw new Exception("Usuário não encontrado!");

                usuario.Update(usuarioDTO.nome,
                               usuarioDTO.sobrenome,
                               usuarioDTO.email,
                               usuarioDTO.dataNascimento,
                               usuarioDTO.escolaridadeId);

                _usuarioService.Update(usuario);

                return new RetornoPadraoDTO("Usuário atualizado com sucesso!", RetornoPadraoStatusStatic.Sucesso.Id);
            }
            catch (ArgumentException ex)
            {
                return new RetornoPadraoDTO(ex.Message, RetornoPadraoStatusStatic.Alerta.Id);
            }
            catch (Exception ex)
            {
                return new RetornoPadraoDTO(ex.Message, RetornoPadraoStatusStatic.Erro.Id);
            }            
        }               

        public RetornoPadraoDTO Deletar(long id)
        {
            try
            {
                var usuario = _usuarioService.GetById(id);

                if (usuario == null)
                    throw new Exception("Usuário não encontrado!");

                _usuarioService.Remove(usuario);

                return new RetornoPadraoDTO("Usuário removido com sucesso!", RetornoPadraoStatusStatic.Sucesso.Id);
            }
            catch (ArgumentException ex)
            {
                return new RetornoPadraoDTO(ex.Message, RetornoPadraoStatusStatic.Alerta.Id);
            }
            catch (Exception ex)
            {
                return new RetornoPadraoDTO(ex.Message, RetornoPadraoStatusStatic.Erro.Id);
            }
            
        }
    }
}
