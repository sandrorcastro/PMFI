using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class AlmTipoSaidum
{
    public int TipoSaidaId { get; set; }

    public string? Tsnome { get; set; }

    public string? Tsfuncao { get; set; }

    public string? Tsobservacao { get; set; }

    public virtual ICollection<AlmSaida> AlmSaida { get; set; } = new List<AlmSaida>();
}
