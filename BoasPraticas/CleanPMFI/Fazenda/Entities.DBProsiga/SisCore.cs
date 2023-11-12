using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class SisCore
{
    public int SicoId { get; set; }

    public string? SicoNome { get; set; }

    public virtual ICollection<TribQuadraLograd> TribQuadraLograds { get; set; } = new List<TribQuadraLograd>();
}
