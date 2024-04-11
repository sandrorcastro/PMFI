using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribAcabamentoInterno
{
    public int AcabIntId { get; set; }

    public string? AcabIntNome { get; set; }

    public decimal? AcabIntFator { get; set; }

    public int? AcabIntPontos { get; set; }

    public virtual ICollection<TribEdificaco> TribEdificacos { get; set; } = new List<TribEdificaco>();
}
