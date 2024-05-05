using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribFiscTermoDeDevolucaoDocumento
{
    public int FiscIdtermoDevolucao { get; set; }

    public int FiscIdtermoRetencao { get; set; }

    public int FiscIddocumento { get; set; }

    public string? FiscComplemento { get; set; }

    public virtual TribFiscTermoDeDevolucao FiscIdtermoDevolucaoNavigation { get; set; } = null!;

    public virtual TribFiscTermoDeRetencaoDocumento TribFiscTermoDeRetencaoDocumento { get; set; } = null!;
}
