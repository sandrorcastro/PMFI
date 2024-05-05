using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribPedologium
{
    public int PedoId { get; set; }

    public string? PedoNome { get; set; }

    public decimal? PedoFator { get; set; }

    public int PedoPontos { get; set; }

    public virtual ICollection<TribTerreno> TribTerrenos { get; set; } = new List<TribTerreno>();
}
