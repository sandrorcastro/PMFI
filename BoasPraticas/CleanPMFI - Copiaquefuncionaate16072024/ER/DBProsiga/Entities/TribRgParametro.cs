using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribRgParametro
{
    public long IdParametro { get; set; }

    public string? NmParametro { get; set; }

    public string? TpParametro { get; set; }

    public string? NmIdentificador { get; set; }

    public virtual ICollection<TribRgFiltro> IdFiltros { get; set; } = new List<TribRgFiltro>();
}
