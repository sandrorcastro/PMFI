using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class FissModeloNotum
{
    public int ModNotaId { get; set; }

    public string? ModNota { get; set; }

    public virtual ICollection<FissDocFiscai> FissDocFiscais { get; set; } = new List<FissDocFiscai>();
}
