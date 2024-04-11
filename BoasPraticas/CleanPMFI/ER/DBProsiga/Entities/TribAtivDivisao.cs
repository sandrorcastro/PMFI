using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribAtivDivisao
{
    public string AtivDiv { get; set; } = null!;

    public string? AtivDivDenom { get; set; }

    public string AtivSecao { get; set; } = null!;

    public virtual TribAtivSecao AtivSecaoNavigation { get; set; } = null!;

    public virtual ICollection<TribAtivGrupo> TribAtivGrupos { get; set; } = new List<TribAtivGrupo>();
}
