using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinEventosContabei
{
    public short IdEmpresa { get; set; }

    public int CdEvento { get; set; }

    public string? DsEvento { get; set; }

    public bool? FlEstorno { get; set; }

    public bool? FlLancaManual { get; set; }

    public bool? FlDividaFundada { get; set; }

    public int? CdEventoEstorno { get; set; }

    public int? CdTc { get; set; }

    public bool? FlDesativado { get; set; }
}
