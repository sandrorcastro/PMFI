using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class AlmoxarifLote
{
    public long AlmoxId { get; set; }

    public long ItemId { get; set; }

    public long LoteId { get; set; }

    public decimal? AlmLotQtdeEntrada { get; set; }

    public decimal? AlmLotQtdeSaida { get; set; }

    public virtual ICollection<AlmEntradaIten> AlmEntradaItens { get; set; } = new List<AlmEntradaIten>();

    public virtual ICollection<AlmSaidasIten> AlmSaidasItens { get; set; } = new List<AlmSaidasIten>();

    public virtual Almoxarifado Almox { get; set; } = null!;

    public virtual AlmIten Item { get; set; } = null!;

    public virtual AlmLote Lote { get; set; } = null!;
}
