using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbIpmFinanceiroFolha
{
    public int IdMovimento { get; set; }

    public int? IdSegurado { get; set; }

    public string? IdEvento { get; set; }

    public decimal? VlEvento { get; set; }

    public string? NrTotal { get; set; }

    public short? NrAno { get; set; }

    public short? NrMes { get; set; }

    public string? DsReferencia { get; set; }

    public string? DsReferenciaTotal { get; set; }
}
