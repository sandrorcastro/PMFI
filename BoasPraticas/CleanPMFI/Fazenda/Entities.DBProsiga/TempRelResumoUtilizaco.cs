using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TempRelResumoUtilizaco
{
    public short Faixa { get; set; }

    public decimal? De { get; set; }

    public decimal? Ate { get; set; }
}
