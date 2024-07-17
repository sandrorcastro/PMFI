using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SaudeApresentacao
{
    public int IdApresentacao { get; set; }

    public string? DsApresentacao { get; set; }

    public virtual ICollection<SaudeMedicamentoXxxxxx> SaudeMedicamentoXxxxxxes { get; set; } = new List<SaudeMedicamentoXxxxxx>();
}
