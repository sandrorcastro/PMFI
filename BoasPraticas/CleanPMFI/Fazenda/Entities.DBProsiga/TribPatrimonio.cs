using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribPatrimonio
{
    public int PatrId { get; set; }

    public string? PatrNome { get; set; }

    public decimal? PatrFator { get; set; }

    public int PatrPontos { get; set; }

    public virtual ICollection<TribTerreno> TribTerrenos { get; set; } = new List<TribTerreno>();
}
