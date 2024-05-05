using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribRgFiltro
{
    public int IdFiltro { get; set; }

    public string? NmFiltro { get; set; }

    public string? TpFiltro { get; set; }

    public long? IdRegra { get; set; }

    public virtual ICollection<TribRgParametro> IdParametros { get; set; } = new List<TribRgParametro>();

    public virtual ICollection<TribRgRotina> IdRotinas { get; set; } = new List<TribRgRotina>();
}
