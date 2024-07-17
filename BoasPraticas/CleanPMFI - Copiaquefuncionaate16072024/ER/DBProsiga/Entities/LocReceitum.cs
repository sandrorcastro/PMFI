using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class LocReceitum
{
    public string ReceitaCodigo { get; set; } = null!;

    public string? RecDescricao { get; set; }

    public int? RecConvenioId { get; set; }

    public virtual ICollection<LocTaxa> LocTaxas { get; set; } = new List<LocTaxa>();

    public virtual ConvenioBanco? RecConvenio { get; set; }
}
