using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class FissSituacaoRec
{
    public int SitRecId { get; set; }

    public string? SitRecNome { get; set; }

    public string? SitRecNotaEmitida { get; set; }

    public string? SitRecNotaRecebida { get; set; }

    public string? SitRecSubstituto { get; set; }

    public virtual ICollection<FissDocFiscai> FissDocFiscais { get; set; } = new List<FissDocFiscai>();
}
