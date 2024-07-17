using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribFiscOsreclamaco
{
    public int FiscOsid { get; set; }

    public long ReclId { get; set; }

    public virtual TribFiscOrdemServico FiscOs { get; set; } = null!;
}
