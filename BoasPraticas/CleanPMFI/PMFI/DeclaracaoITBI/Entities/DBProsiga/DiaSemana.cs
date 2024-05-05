using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class DiaSemana
{
    public int IdDiaSemana { get; set; }

    public string? DiaSemana1 { get; set; }

    public virtual ICollection<SaudeEscala> IdEscalas { get; set; } = new List<SaudeEscala>();
}
