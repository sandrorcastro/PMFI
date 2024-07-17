using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class FissDocFiscaisDividum
{
    public long DodiId { get; set; }

    public long? DocfisId { get; set; }

    public long? DivEmpId { get; set; }

    public virtual TribDividasEmpresa? DivEmp { get; set; }

    public virtual FissDocFiscai? Docfis { get; set; }
}
