using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribAtivAtividadeGrauRiscoOld
{
    public string Atividade { get; set; } = null!;

    public short SetorId { get; set; }

    public string? Risco { get; set; }
}
