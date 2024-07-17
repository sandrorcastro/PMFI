using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribEsquadria
{
    public int EsquadriasId { get; set; }

    public string? EsquadriasNome { get; set; }

    public decimal? EsquadriasFator { get; set; }

    public int? EsquadriasPontos { get; set; }

    public virtual ICollection<TribEdificaco> TribEdificacos { get; set; } = new List<TribEdificaco>();
}
