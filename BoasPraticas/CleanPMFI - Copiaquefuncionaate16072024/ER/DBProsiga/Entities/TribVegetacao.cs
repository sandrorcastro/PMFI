using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribVegetacao
{
    public int VegeId { get; set; }

    public string? VegeNome { get; set; }

    public decimal? VegeFator { get; set; }

    public int VegePontos { get; set; }

    public virtual ICollection<TribTerreno> TribTerrenos { get; set; } = new List<TribTerreno>();
}
