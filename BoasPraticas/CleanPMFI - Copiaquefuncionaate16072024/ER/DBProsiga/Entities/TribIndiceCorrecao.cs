using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribIndiceCorrecao
{
    public DateTime IndCorrData { get; set; }

    public decimal? IndCorrIndice { get; set; }
}
