using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspReversaoEstorno
{
    public int IdReversao { get; set; }

    public int IdEstorno { get; set; }

    public short? NrAno { get; set; }

    public short? NrSequencia { get; set; }

    public short? NrReversao { get; set; }

    public DateTime? DtReversao { get; set; }

    public decimal? VlReversao { get; set; }

    public string? DsMotivo { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public virtual TbDspEstornosEmpenho IdEstornoNavigation { get; set; } = null!;

    public virtual ICollection<TbDspReversaoEstornosItem> TbDspReversaoEstornosItems { get; set; } = new List<TbDspReversaoEstornosItem>();
}
