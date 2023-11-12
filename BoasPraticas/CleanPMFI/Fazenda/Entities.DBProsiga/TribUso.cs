using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribUso
{
    public int UsoId { get; set; }

    public string? UsoNome { get; set; }

    public decimal? UsoFator { get; set; }

    public int? UsoPontos { get; set; }

    public virtual ICollection<TribEdificaco> TribEdificacos { get; set; } = new List<TribEdificaco>();
}
