using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class LocTpSubLocal
{
    public int TipoSubLocId { get; set; }

    public string? TsnmTipo { get; set; }

    public string? TstecUltAlt { get; set; }

    public DateTime? TsdtUltAlt { get; set; }

    public virtual ICollection<LocSubLocal> LocSubLocals { get; set; } = new List<LocSubLocal>();
}
