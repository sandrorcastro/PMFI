using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspConsignacoesIten
{
    public int IdConsignacao { get; set; }

    public int IdNatDespesa { get; set; }

    public decimal? VlTotal { get; set; }

    public virtual TbDspConsignaco IdConsignacaoNavigation { get; set; } = null!;
}
