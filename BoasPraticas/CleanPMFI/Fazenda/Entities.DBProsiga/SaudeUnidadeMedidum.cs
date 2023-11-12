using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class SaudeUnidadeMedidum
{
    public int IdUnidadeMedida { get; set; }

    public string? DsUnidadeMedida { get; set; }

    public virtual ICollection<SaudeMedicamentoXxxxxx> SaudeMedicamentoXxxxxxes { get; set; } = new List<SaudeMedicamentoXxxxxx>();
}
