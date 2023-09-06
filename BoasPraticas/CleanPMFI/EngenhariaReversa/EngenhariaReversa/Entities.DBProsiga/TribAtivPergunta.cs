using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribAtivPergunta
    {
        public short PerguntaNumero { get; set; }
        public string Pergunta { get; set; } = null!;
    }
}
