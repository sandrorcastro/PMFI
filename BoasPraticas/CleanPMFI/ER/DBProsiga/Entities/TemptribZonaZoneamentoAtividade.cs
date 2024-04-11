using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TemptribZonaZoneamentoAtividade
{
    public short ZozoId { get; set; }

    public string Atividade { get; set; } = null!;

    public short ZotlId { get; set; }
}
