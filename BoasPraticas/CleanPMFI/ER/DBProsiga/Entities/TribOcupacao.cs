using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribOcupacao
{
    public int OcupaId { get; set; }

    public string? OcupaNome { get; set; }

    public decimal? OcupaFator { get; set; }

    public int OcupaPontos { get; set; }

    public string OcupaCalculaImpostos { get; set; } = null!;

    public virtual ICollection<TribEdificaco> TribEdificacos { get; set; } = new List<TribEdificaco>();
}
