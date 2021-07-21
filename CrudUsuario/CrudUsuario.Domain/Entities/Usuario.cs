using System;
using System.Collections.Generic;
using System.Text;

namespace CrudUsuario.Domain.Entities
{
    public class Usuario
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public short Escolaridade { get; set; }
    }
}
