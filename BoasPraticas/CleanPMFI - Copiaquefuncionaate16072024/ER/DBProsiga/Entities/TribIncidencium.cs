using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribIncidencium
{
    public int InciId { get; set; }

    public string? InciNome { get; set; }

    public decimal? InciFator { get; set; }

    public int InciPontos { get; set; }

    public virtual ICollection<TribEdificaco> TribEdificacos { get; set; } = new List<TribEdificaco>();

    public virtual ICollection<TribTerreno> TribTerrenos { get; set; } = new List<TribTerreno>();
}
