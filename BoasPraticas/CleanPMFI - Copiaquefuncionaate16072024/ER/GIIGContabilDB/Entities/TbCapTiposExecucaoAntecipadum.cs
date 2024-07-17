using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCapTiposExecucaoAntecipadum
{
    public short IdTipoExecucaoAntecipada { get; set; }

    public string? DsTipoExecucaoAntecipada { get; set; }

    public virtual ICollection<TbCapExecucaoAntecipadum> TbCapExecucaoAntecipada { get; set; } = new List<TbCapExecucaoAntecipadum>();
}
