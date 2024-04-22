using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SaudeTipoMedicamento
{
    public int IdTipoMedicamento { get; set; }

    public string? DsTipoMedicamento { get; set; }

    public virtual ICollection<SaudeMedicamentoXxxxxx> SaudeMedicamentoXxxxxxes { get; set; } = new List<SaudeMedicamentoXxxxxx>();
}
