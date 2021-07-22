using CrudUsuario.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudUsuario.Domain.Entities
{
    public class Usuario
    {
        public long Id { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Email { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public short Escolaridade { get; private set; }

        public Usuario(string nome, string sobrenome, string email, DateTime dataNascimento, short escolaridade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            DataNascimento = dataNascimento;
            Escolaridade = escolaridade;

            Valida();
        }

        public Usuario Update(string nome, string sobrenome, string email, DateTime dataNascimento, short escolaridade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            DataNascimento = dataNascimento;
            Escolaridade = escolaridade;

            Valida();

            return this;
        }

        private void Valida()
        {
            if (!Entities.Email.EmailValido(Email))
                throw new ArgumentException("Informe um e-mail válido!");

            if (DataNascimento > DateTime.Now)
                throw new ArgumentException("A data de nascimento não pode ser maior que hoje!");

            if (!Enum.IsDefined(typeof(EscolaridadeEnum), (int)Escolaridade))
                throw new ArgumentException("Informe a escolaridade!");      
        }
    }
}
