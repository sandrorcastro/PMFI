using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class FissCompDividum
{
    public long CompDivId { get; set; }

    public long? CompId { get; set; }

    public long? DivEmpId { get; set; }

    public virtual FissComprovante? Comp { get; set; }

    public virtual TribDividasEmpresa? DivEmp { get; set; }
}
