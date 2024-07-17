using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPpaPublicosAlvo
{
    public int IdPublicoAlvo { get; set; }

    public string? DsPublicoAlvo { get; set; }

    public virtual ICollection<TbPpaIndicadore> TbPpaIndicadores { get; set; } = new List<TbPpaIndicadore>();
}
