using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class LocReceitum
{
    public string ReceitaCodigo { get; set; } = null!;

    public string? RecDescricao { get; set; }

    public int? RecConvenioId { get; set; }

    public virtual ICollection<LocTaxa> LocTaxas { get; set; } = new List<LocTaxa>();

    public virtual ConvenioBanco? RecConvenio { get; set; }
}
