using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class SaudeProgramaSaude
{
    public int IdPrograma { get; set; }

    public string? DsPrograma { get; set; }

    public virtual ICollection<SaudeMedicamentoXxxxxx> IdMedicamentos { get; set; } = new List<SaudeMedicamentoXxxxxx>();
}
