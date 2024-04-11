using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbSbsTipoDespesa
{
    public int CdTipoDespesa { get; set; }

    public string? DsTipoDespesa { get; set; }

    public string? CdNatDespesa { get; set; }

    public virtual ICollection<TbSbsCategoriasDespesa> IdCatDespesas { get; set; } = new List<TbSbsCategoriasDespesa>();
}
