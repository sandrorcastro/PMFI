using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SisLogDadosComposicao
{
    public long LoDaCoId { get; set; }

    public long LoDaId { get; set; }

    public string Chave { get; set; } = null!;

    public string Valor { get; set; } = null!;
}
