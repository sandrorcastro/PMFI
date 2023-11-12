using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class VwConsultapreviaPerguntar
{
    public short PerguntaNumero { get; set; }

    public string Pergunta { get; set; } = null!;
}
