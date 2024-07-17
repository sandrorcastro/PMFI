using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCntTiposPartesContrato
{
    public short IdTipoParteContrato { get; set; }

    public string? DsTipoParteContrato { get; set; }

    public bool? FlAtivo { get; set; }
}
