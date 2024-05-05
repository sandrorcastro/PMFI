using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribCmprocessoLagrad
{
    public long CmprocId { get; set; }

    public int LogradId { get; set; }

    public string? CmprocLogradIntervaloRua { get; set; }

    public virtual TribCmprocesso Cmproc { get; set; } = null!;

    public virtual Logradouro Lograd { get; set; } = null!;
}
