using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerTipoInvestimento
{
    public short IdTipoInvestimento { get; set; }

    public string? DsTipoInvstimento { get; set; }

    public string? FlPrevidencia { get; set; }

    public virtual ICollection<TbCapRecursosContasCorrente> TbCapRecursosContasCorrentes { get; set; } = new List<TbCapRecursosContasCorrente>();
}
