using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribEstadoConservacao
{
    public int EstConservId { get; set; }

    public string? EstConservNome { get; set; }

    public decimal? EstConservFator { get; set; }

    public int? EstConservPontos { get; set; }

    public virtual ICollection<TribEdificaco> TribEdificacos { get; set; } = new List<TribEdificaco>();
}
