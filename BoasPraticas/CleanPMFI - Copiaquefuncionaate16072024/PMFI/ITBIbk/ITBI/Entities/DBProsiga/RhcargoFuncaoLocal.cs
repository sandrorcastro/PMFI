using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class RhcargoFuncaoLocal
{
    public int LocId { get; set; }

    public long CargoFuncId { get; set; }

    public int? CarFqtdeVagas { get; set; }

    public int? CarFocupada { get; set; }

    public virtual RhcargosFunco CargoFunc { get; set; } = null!;

    public virtual Localizacao Loc { get; set; } = null!;
}
