using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribDividasBkp
{
    public int AltId { get; set; }

    public long? ImoIddivida { get; set; }

    public int? TipoBxId { get; set; }

    public decimal? ImoDivValorBaixa { get; set; }

    public string? Usuario { get; set; }

    public DateTime? DataInclusao { get; set; }

    public DateTime? DataExclusao { get; set; }
}
