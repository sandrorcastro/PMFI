using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribCobertura
{
    public int CobertId { get; set; }

    public string? CobertNome { get; set; }

    public decimal? CobertFator { get; set; }

    public int? CobertPontos { get; set; }

    public virtual ICollection<TribEdificaco> TribEdificacos { get; set; } = new List<TribEdificaco>();
}
