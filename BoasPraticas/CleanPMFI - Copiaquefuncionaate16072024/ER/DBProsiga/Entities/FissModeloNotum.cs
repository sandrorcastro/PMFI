using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class FissModeloNotum
{
    public int ModNotaId { get; set; }

    public string? ModNota { get; set; }

    public virtual ICollection<FissDocFiscai> FissDocFiscais { get; set; } = new List<FissDocFiscai>();
}
