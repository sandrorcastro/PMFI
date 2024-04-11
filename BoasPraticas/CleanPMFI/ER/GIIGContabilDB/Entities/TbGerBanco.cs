using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerBanco
{
    public string CdBanco { get; set; } = null!;

    public string? NrDv { get; set; }

    public string? NmBanco { get; set; }

    public string? DsTipo { get; set; }

    public virtual ICollection<TbGerAgencia> TbGerAgencia { get; set; } = new List<TbGerAgencia>();
}
