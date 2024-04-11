using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcTipoCreditoInicial
{
    public short IdTipoCreditoInicial { get; set; }

    public string? DsTipoCreditoInicial { get; set; }

    public virtual ICollection<TbOrcDotaco> TbOrcDotacos { get; set; } = new List<TbOrcDotaco>();
}
