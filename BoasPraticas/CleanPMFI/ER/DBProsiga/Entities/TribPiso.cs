using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribPiso
{
    public int PisoId { get; set; }

    public string? PisoNome { get; set; }

    public decimal? PisoFator { get; set; }

    public int? PisoPontos { get; set; }

    public virtual ICollection<TribEdificaco> TribEdificacos { get; set; } = new List<TribEdificaco>();
}
