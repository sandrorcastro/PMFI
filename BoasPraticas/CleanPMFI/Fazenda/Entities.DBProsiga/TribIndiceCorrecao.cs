using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribIndiceCorrecao
{
    public DateTime IndCorrData { get; set; }

    public decimal? IndCorrIndice { get; set; }
}
