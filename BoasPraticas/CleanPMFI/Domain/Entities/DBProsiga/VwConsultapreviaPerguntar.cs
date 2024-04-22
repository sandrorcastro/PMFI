using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class VwConsultapreviaPerguntar
    {
        public short PerguntaNumero { get; set; }
        public string Pergunta { get; set; } = null!;
    }
}
