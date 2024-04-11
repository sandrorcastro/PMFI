using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinTiposServico
{
    public int IdTipoServico { get; set; }

    public string CdTipoServico { get; set; } = null!;

    public string? DsTipoServico { get; set; }

    public bool? FlusaRemessa { get; set; }
}
