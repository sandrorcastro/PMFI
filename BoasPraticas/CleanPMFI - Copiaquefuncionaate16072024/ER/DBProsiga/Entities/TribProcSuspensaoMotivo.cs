using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribProcSuspensaoMotivo
{
    public long ProcSuspId { get; set; }

    public int ProcMotId { get; set; }

    public string? ProcSuspMotObs { get; set; }

    public virtual TribProcMotivo ProcMot { get; set; } = null!;

    public virtual TribProcSuspensao ProcSusp { get; set; } = null!;
}
