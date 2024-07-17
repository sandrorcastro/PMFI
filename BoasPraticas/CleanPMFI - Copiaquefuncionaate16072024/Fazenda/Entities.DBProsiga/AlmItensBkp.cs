using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class AlmItensBkp
{
    public long ItemId { get; set; }

    public int? ItemEspecieId { get; set; }

    public int? ItemMarcaId { get; set; }

    public int? ItemModeloId { get; set; }

    public int? ItemUnMedId { get; set; }

    public string? ItemNome { get; set; }

    public string? ItemObserv { get; set; }

    public string? ItemCodBarra { get; set; }

    public decimal? ItemVlrUnitario { get; set; }
}
