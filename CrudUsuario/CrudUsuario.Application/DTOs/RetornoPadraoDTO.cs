using System;
using System.Collections.Generic;
using System.Text;

namespace CrudUsuario.Application.DTOs
{
    public class RetornoPadraoDTO
    {
        public long? Id { get; set; }
        public string Mensagem { get; set; }
        public int Status { get; set; }

        public Object EntidadeRetorno { get; set; }

        public RetornoPadraoDTO(string mensagem, int status, long? id = null)
        {
            Id = id;
            Mensagem = mensagem;
            Status = status;
        }
    }
}
