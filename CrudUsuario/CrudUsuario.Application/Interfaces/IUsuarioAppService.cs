using CrudUsuario.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudUsuario.Application.Interfaces
{
    public interface IUsuarioAppService
    {
        IEnumerable<UsuarioDTO> GetUsuarios();

        UsuarioDTO GetUsuarioById(long id);

        RetornoPadraoDTO Criar(UsuarioDTO usuarioDTO);

        RetornoPadraoDTO Editar(UsuarioDTO usuarioDTO);

        RetornoPadraoDTO Deletar(long id);
    }
}
