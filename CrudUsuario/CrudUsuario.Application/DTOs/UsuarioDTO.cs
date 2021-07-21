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
        public long Id { get; private set; }       
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Email { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public short EscolaridadeId { get; private set; }
        public string NomeSobrenome => string.Format("{0} {1}", Nome, Sobrenome);
        public string Escolaridade => EnumHelper.GetDescription((EscolaridadeEnum)EscolaridadeId);

        public UsuarioDTO(Usuario usuario)
        {
            Id = usuario.Id;
            Nome = usuario.Nome;
            Sobrenome = usuario.Sobrenome;
            Email = usuario.Email;
            DataNascimento = usuario.DataNascimento;
            EscolaridadeId = usuario.Escolaridade;
        }
    }
}
