using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribFiscDocumento
{
    public int FiscIddocumento { get; set; }

    public string? FiscNomeDocumento { get; set; }

    public string? FiscSituacao { get; set; }

    public virtual ICollection<TribFiscTermoDeRetencaoDocumento> TribFiscTermoDeRetencaoDocumentos { get; set; } = new List<TribFiscTermoDeRetencaoDocumento>();
}
