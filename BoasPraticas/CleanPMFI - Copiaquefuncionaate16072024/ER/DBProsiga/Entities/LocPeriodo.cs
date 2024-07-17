using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class LocPeriodo
{
    public int PeriodoId { get; set; }

    public string? PerDescricao { get; set; }

    public string? PerValidade { get; set; }

    public string? PerTecUltAlt { get; set; }

    public DateTime? PerDtUltAlt { get; set; }

    public virtual ICollection<LocTaxa> LocTaxas { get; set; } = new List<LocTaxa>();
}
