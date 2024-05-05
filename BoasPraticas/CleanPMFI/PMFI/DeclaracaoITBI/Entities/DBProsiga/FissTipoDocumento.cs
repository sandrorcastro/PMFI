using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class FissTipoDocumento
{
    public int TipoDocId { get; set; }

    public string? TipoDocNome { get; set; }

    public virtual ICollection<FissDocFiscai> FissDocFiscais { get; set; } = new List<FissDocFiscai>();
}
