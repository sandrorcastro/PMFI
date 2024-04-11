using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class AlvaraConstrucaoProcesso
{
    public long ProcId { get; set; }

    public long Numero { get; set; }

    public virtual Processo Proc { get; set; } = null!;
}
