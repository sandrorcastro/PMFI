using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribForro
{
    public int ForroId { get; set; }

    public string? ForroNome { get; set; }

    public decimal? ForroFator { get; set; }

    public int? ForroPontos { get; set; }

    public virtual ICollection<TribEdificaco> TribEdificacos { get; set; } = new List<TribEdificaco>();
}
