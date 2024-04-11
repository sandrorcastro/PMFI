using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SaudeProgramaSaude
{
    public int IdPrograma { get; set; }

    public string? DsPrograma { get; set; }

    public virtual ICollection<SaudeMedicamentoXxxxxx> IdMedicamentos { get; set; } = new List<SaudeMedicamentoXxxxxx>();
}
