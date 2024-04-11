using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCtcCentroCustosCriterio
{
    public int IdCentroCusto { get; set; }

    public int IdCriterio { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtInclusao { get; set; }

    public virtual TbCtcCentroCusto IdCentroCustoNavigation { get; set; } = null!;

    public virtual TbCtcCriterio IdCriterioNavigation { get; set; } = null!;
}
