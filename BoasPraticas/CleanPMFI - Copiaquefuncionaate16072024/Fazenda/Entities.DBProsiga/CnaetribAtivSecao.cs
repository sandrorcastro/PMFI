using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class CnaetribAtivSecao
{
    public string AtivSecao { get; set; } = null!;

    public string? AtivSecaoDenom { get; set; }

    public virtual ICollection<CnaetribAtivDivisao> CnaetribAtivDivisaos { get; set; } = new List<CnaetribAtivDivisao>();
}
