using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribProcRecursosOrigem
{
    public int ProcRecOrigemId { get; set; }

    public string? ProcRecOrigemNome { get; set; }

    public virtual ICollection<TribProcRecursosOrigemDet> TribProcRecursosOrigemDets { get; set; } = new List<TribProcRecursosOrigemDet>();
}
