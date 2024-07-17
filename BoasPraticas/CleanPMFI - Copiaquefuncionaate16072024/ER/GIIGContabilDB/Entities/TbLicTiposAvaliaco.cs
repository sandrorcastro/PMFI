using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicTiposAvaliaco
{
    public short IdTipoAvaliacao { get; set; }

    public string? DsTipoAvaliacao { get; set; }

    public string? FlPadraoTce { get; set; }

    public short? CdTc { get; set; }

    public bool? FlAtivo { get; set; }
}
