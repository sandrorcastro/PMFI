using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribUtilizacao
{
    public int UtilizId { get; set; }

    public string? UtilizNome { get; set; }

    public decimal? UtilizFator { get; set; }

    public int? UtilizPontos { get; set; }

    public virtual ICollection<TribEdificaco> TribEdificacos { get; set; } = new List<TribEdificaco>();
}
