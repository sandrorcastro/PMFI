using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribInstalacaoSanitarium
{
    public int InstSanitId { get; set; }

    public string? InstSanitNome { get; set; }

    public decimal? InstSanitFator { get; set; }

    public int? InstSanitPontos { get; set; }

    public virtual ICollection<TribEdifInstSanitarium> TribEdifInstSanitaria { get; set; } = new List<TribEdifInstSanitarium>();
}
