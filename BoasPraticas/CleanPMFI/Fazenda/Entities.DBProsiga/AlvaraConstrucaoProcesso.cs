using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class AlvaraConstrucaoProcesso
{
    public long ProcId { get; set; }

    public long Numero { get; set; }

    public virtual Processo Proc { get; set; } = null!;
}
