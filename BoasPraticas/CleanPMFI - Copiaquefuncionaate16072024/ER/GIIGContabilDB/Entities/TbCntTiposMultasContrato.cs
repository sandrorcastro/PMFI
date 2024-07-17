using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCntTiposMultasContrato
{
    public short IdTipoMultaContrato { get; set; }

    public string? DsTipoMultaContrato { get; set; }

    public bool? FlUsaDetalhes { get; set; }

    public virtual ICollection<TbCntContrato> TbCntContratos { get; set; } = new List<TbCntContrato>();
}
