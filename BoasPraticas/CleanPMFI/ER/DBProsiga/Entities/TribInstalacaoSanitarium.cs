using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribInstalacaoSanitarium
{
    public int InstSanitId { get; set; }

    public string? InstSanitNome { get; set; }

    public decimal? InstSanitFator { get; set; }

    public int? InstSanitPontos { get; set; }

    public virtual ICollection<TribEdifInstSanitarium> TribEdifInstSanitaria { get; set; } = new List<TribEdifInstSanitarium>();
}
