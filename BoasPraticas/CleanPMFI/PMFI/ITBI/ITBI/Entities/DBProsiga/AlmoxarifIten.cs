using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class AlmoxarifIten
{
    public long AlmoxId { get; set; }

    public long ItemId { get; set; }

    public decimal? QtdeEntrada { get; set; }

    public decimal? QtdeSaida { get; set; }

    public decimal? QtdeReservada { get; set; }

    public decimal? EstoqueMin { get; set; }

    public decimal? EstoqueMax { get; set; }

    public virtual ICollection<AlmEntradaIten> AlmEntradaItens { get; set; } = new List<AlmEntradaIten>();

    public virtual ICollection<AlmRequisicoesIten> AlmRequisicoesItens { get; set; } = new List<AlmRequisicoesIten>();

    public virtual ICollection<AlmSaidasIten> AlmSaidasItens { get; set; } = new List<AlmSaidasIten>();

    public virtual Almoxarifado Almox { get; set; } = null!;

    public virtual AlmIten Item { get; set; } = null!;
}
