using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribTopografium
{
    public int TopoId { get; set; }

    public string? TopoNome { get; set; }

    public decimal? TopoFator { get; set; }

    public int TopoPontos { get; set; }

    public virtual ICollection<TribTerreno> TribTerrenos { get; set; } = new List<TribTerreno>();
}
