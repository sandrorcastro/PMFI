using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaAreasProjecaoReceitum
{
    public short CdArea { get; set; }

    public string? DsArea { get; set; }

    public virtual ICollection<TbPlaProjecoesReceita> TbPlaProjecoesReceita { get; set; } = new List<TbPlaProjecoesReceita>();
}
