using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrudUsuario.Domain.Statics
{
    public class RetornoPadraoStatusStatic
    {

        public int Id { get; private set; }
        public string Nome { get; private set; }

        public RetornoPadraoStatusStatic(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public static RetornoPadraoStatusStatic Sucesso = new RetornoPadraoStatusStatic(1, "success");
        public static RetornoPadraoStatusStatic Alerta = new RetornoPadraoStatusStatic(2, "warning");
        public static RetornoPadraoStatusStatic Erro = new RetornoPadraoStatusStatic(3, "error");
        public static RetornoPadraoStatusStatic Pergunta = new RetornoPadraoStatusStatic(4, "question");

        public static List<RetornoPadraoStatusStatic> ToList()
        {
            return new List<RetornoPadraoStatusStatic>()
            {
                Sucesso,
                Alerta,
                Erro
            };
        }

        public static RetornoPadraoStatusStatic GetById(int id)
        {
            return ToList().FirstOrDefault(x => x.Id == id);
        }
    }
}
