using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class FissTipoDocumento
{
    public int TipoDocId { get; set; }

    public string? TipoDocNome { get; set; }

    public virtual ICollection<FissDocFiscai> FissDocFiscais { get; set; } = new List<FissDocFiscai>();
}
