using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspReversaoEstornosItem
{
    public int IdReversaoItem { get; set; }

    public int IdReversao { get; set; }

    public int IdItem { get; set; }

    public int? NrLote { get; set; }

    public string? DsItemCompl { get; set; }

    public decimal? NrQtde { get; set; }

    public decimal? VlTotal { get; set; }

    public int? IdNatDespesa { get; set; }

    public virtual TbDspReversaoEstorno IdReversaoNavigation { get; set; } = null!;
}
