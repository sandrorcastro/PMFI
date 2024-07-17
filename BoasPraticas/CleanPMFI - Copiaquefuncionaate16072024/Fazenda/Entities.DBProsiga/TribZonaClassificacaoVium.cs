using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribZonaClassificacaoVium
{
    public int ClViId { get; set; }

    public string? ClViClassificacao { get; set; }

    public string? ClViDescricao { get; set; }

    public string? ClViCorMapa { get; set; }

    public virtual ICollection<TribQuadraLograd> TribQuadraLograds { get; set; } = new List<TribQuadraLograd>();
}
