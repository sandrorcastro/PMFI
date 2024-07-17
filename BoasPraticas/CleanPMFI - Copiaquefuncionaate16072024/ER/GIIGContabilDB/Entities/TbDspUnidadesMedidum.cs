using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspUnidadesMedidum
{
    public short IdUnidadeMedida { get; set; }

    public string? NmUnidadeMedida { get; set; }

    public short? IdUnidadeMedidaPadrao { get; set; }

    public virtual TbPlaUnidadesMedidasPadrao? IdUnidadeMedidaPadraoNavigation { get; set; }

    public virtual ICollection<TbDspIten> TbDspItens { get; set; } = new List<TbDspIten>();
}
