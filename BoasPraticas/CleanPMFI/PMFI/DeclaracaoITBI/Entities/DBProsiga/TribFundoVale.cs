using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribFundoVale
{
    public int FundoId { get; set; }

    public string? FundoNome { get; set; }

    public decimal? FundoFator { get; set; }

    public int FundoPontos { get; set; }

    public virtual ICollection<TribTerreno> TribTerrenos { get; set; } = new List<TribTerreno>();
}
