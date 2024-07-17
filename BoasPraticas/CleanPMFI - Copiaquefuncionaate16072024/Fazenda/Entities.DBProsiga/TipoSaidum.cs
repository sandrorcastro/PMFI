using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TipoSaidum
{
    public int Tsid { get; set; }

    public string? Tsdescricao { get; set; }

    public string? TscalculaKm { get; set; }

    public string? TsbaixaEst { get; set; }
}
