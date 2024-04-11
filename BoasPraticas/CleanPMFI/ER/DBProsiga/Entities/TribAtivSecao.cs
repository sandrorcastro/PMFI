using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribAtivSecao
{
    public string AtivSecao { get; set; } = null!;

    public string? AtivSecaoDenom { get; set; }

    public virtual ICollection<TribAtivDivisao> TribAtivDivisaos { get; set; } = new List<TribAtivDivisao>();
}
