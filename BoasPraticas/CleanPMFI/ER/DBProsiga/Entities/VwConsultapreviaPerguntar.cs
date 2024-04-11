using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class VwConsultapreviaPerguntar
{
    public short PerguntaNumero { get; set; }

    public string Pergunta { get; set; } = null!;
}
