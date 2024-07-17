using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribCalcadum
{
    public int CalcaId { get; set; }

    public string? CalcaNome { get; set; }

    public decimal? CalcaFator { get; set; }

    public int CalcaPontos { get; set; }

    public virtual ICollection<TribTerreno> TribTerrenos { get; set; } = new List<TribTerreno>();
}
