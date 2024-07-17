using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCtcCentroCustosOrgaoUnidade
{
    public int IdCentroCusto { get; set; }

    public string CdOrgao { get; set; } = null!;

    public string CdUnidade { get; set; } = null!;

    public string? DsLogin { get; set; }

    public DateTime? DtInclusao { get; set; }

    public virtual TbCtcCentroCusto IdCentroCustoNavigation { get; set; } = null!;
}
