using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class FissSerieNotasFiscai
{
    public int SerieId { get; set; }

    public string? SerieNome { get; set; }

    public string? SerieNotaEmitida { get; set; }

    public string? SerieNotaRecebida { get; set; }

    public virtual ICollection<FissDocFiscai> FissDocFiscais { get; set; } = new List<FissDocFiscai>();
}
