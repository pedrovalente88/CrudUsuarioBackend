using CrudUsuario.Domain.Entities;
using CrudUsuario.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudUsuario.Application.DTOs
{
    public class UsuarioDTO
    {
        public long id { get; set; }       
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string email { get; set; }
        public DateTime dataNascimento { get; set; }
        public short escolaridadeId { get; set; }
        public string nomeSobrenome => string.Format("{0} {1}", nome, sobrenome);
        public string escolaridade => EnumHelper.GetDescription((EscolaridadeEnum)escolaridadeId);

        //public UsuarioDTO()
        //{

        //}

        public static UsuarioDTO Transformation(Usuario usuario)
        {
            return new UsuarioDTO
            {
                id = usuario.Id,
                nome = usuario.Nome,
                sobrenome = usuario.Sobrenome,
                email = usuario.Email,
                dataNascimento = usuario.DataNascimento,
                escolaridadeId = usuario.Escolaridade,
            };            
        }

        public static Usuario Transformation(UsuarioDTO usuarioDTO)
        {
            return new Usuario(
                usuarioDTO.nome,
                usuarioDTO.sobrenome,
                usuarioDTO.email,
                usuarioDTO.dataNascimento,
                usuarioDTO.escolaridadeId
                );
        }
    }
}
