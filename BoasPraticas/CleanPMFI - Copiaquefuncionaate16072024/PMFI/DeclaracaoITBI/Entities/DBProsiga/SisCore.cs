using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SisCore
{
    public int SicoId { get; set; }

    public string? SicoNome { get; set; }

    public virtual ICollection<TribQuadraLograd> TribQuadraLograds { get; set; } = new List<TribQuadraLograd>();
}
