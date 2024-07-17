using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribAlvaraConstrucaoDividasContrib
{
    public long Numero { get; set; }

    public long ConIddivida { get; set; }

    public virtual TribDividasContribuinte ConIddividaNavigation { get; set; } = null!;
}
