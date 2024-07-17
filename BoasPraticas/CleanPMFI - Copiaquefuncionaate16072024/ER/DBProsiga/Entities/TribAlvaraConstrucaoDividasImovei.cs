using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribAlvaraConstrucaoDividasImovei
{
    public long Numero { get; set; }

    public long ImolDdivida { get; set; }

    public virtual TribDividasImo ImolDdividaNavigation { get; set; } = null!;
}
