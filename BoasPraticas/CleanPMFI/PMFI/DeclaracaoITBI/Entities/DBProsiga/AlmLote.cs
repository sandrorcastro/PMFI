using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class AlmLote
{
    public long LoteId { get; set; }

    public string? LoteNum { get; set; }

    public DateTime LotDtFabric { get; set; }

    public DateTime? LotDtVenc { get; set; }

    public string? LotObserv { get; set; }

    public virtual ICollection<AlmEntradaIten> AlmEntradaItens { get; set; } = new List<AlmEntradaIten>();

    public virtual ICollection<AlmoxarifLote> AlmoxarifLotes { get; set; } = new List<AlmoxarifLote>();
}
