using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class AlmSaidasIten
{
    public long SaidaItemId { get; set; }

    public long? SaidaId { get; set; }

    public long? ReqItemId { get; set; }

    public decimal? SaIqtde { get; set; }

    public string? SaIobs { get; set; }

    public long? AlmoxId { get; set; }

    public long? ItemId { get; set; }

    public long? LoteId { get; set; }

    public virtual AlmoxarifIten? AlmoxarifIten { get; set; }

    public virtual AlmoxarifLote? AlmoxarifLote { get; set; }

    public virtual AlmRequisicoesIten? ReqItem { get; set; }

    public virtual AlmSaida? Saida { get; set; }
}
