using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribFatorK
{
    public long FatorKid { get; set; }

    public string? FatorKnome { get; set; }

    public decimal? FatorKvalor { get; set; }

    public virtual ICollection<TribQuadraLograd> TribQuadraLograds { get; set; } = new List<TribQuadraLograd>();
}
