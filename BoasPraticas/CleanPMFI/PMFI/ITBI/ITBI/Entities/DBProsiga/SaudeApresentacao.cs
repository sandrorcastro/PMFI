using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SaudeApresentacao
{
    public int IdApresentacao { get; set; }

    public string? DsApresentacao { get; set; }

    public virtual ICollection<SaudeMedicamentoXxxxxx> SaudeMedicamentoXxxxxxes { get; set; } = new List<SaudeMedicamentoXxxxxx>();
}
