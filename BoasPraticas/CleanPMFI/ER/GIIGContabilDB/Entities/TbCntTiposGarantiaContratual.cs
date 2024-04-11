using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCntTiposGarantiaContratual
{
    public short IdTipoGarantia { get; set; }

    public string? NmTipoGarantia { get; set; }

    public string? DsSigla { get; set; }

    public short? CdTc { get; set; }

    public bool? FlAtivo { get; set; }

    public bool? FlUsaDetalhes { get; set; }

    public virtual ICollection<TbCntContrato> TbCntContratos { get; set; } = new List<TbCntContrato>();
}
