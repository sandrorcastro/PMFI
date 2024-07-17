using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class Tempcomp
{
    public long ImoIddivida { get; set; }

    public int TipoTribId { get; set; }

    public decimal? CompDivImoValor { get; set; }
}
