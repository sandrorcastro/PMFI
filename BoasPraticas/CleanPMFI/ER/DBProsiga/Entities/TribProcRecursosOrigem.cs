using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribProcRecursosOrigem
{
    public int ProcRecOrigemId { get; set; }

    public string? ProcRecOrigemNome { get; set; }

    public virtual ICollection<TribProcRecursosOrigemDet> TribProcRecursosOrigemDets { get; set; } = new List<TribProcRecursosOrigemDet>();
}
