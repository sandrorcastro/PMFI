using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribLocalizacaoQuadra
{
    public int LocQid { get; set; }

    public string? LocQnome { get; set; }

    public decimal? LocQfator { get; set; }

    public int LocQpontos { get; set; }

    public virtual ICollection<TribTerreno> TribTerrenos { get; set; } = new List<TribTerreno>();
}
