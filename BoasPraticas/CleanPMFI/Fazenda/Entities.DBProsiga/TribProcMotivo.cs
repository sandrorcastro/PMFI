using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribProcMotivo
{
    public int ProcMotId { get; set; }

    public string? ProcMotNome { get; set; }

    public virtual ICollection<TribProcSuspensaoMotivo> TribProcSuspensaoMotivos { get; set; } = new List<TribProcSuspensaoMotivo>();
}
