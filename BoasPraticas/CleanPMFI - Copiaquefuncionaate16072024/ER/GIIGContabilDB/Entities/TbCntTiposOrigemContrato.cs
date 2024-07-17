using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCntTiposOrigemContrato
{
    public short IdTipoOrigemContrato { get; set; }

    public string? DsTipoOrigemContrato { get; set; }

    public virtual ICollection<TbCntContrato> TbCntContratos { get; set; } = new List<TbCntContrato>();
}
