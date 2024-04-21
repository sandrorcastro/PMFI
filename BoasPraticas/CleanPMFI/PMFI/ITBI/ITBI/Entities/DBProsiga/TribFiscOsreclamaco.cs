using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribFiscOsreclamaco
{
    public int FiscOsid { get; set; }

    public long ReclId { get; set; }

    public virtual TribFiscOrdemServico FiscOs { get; set; } = null!;
}
