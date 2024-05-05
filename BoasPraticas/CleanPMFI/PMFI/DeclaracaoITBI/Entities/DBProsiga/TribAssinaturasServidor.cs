using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribAssinaturasServidor
{
    public int ServId { get; set; }

    public int IdDocumento { get; set; }

    public string? NmCargo { get; set; }

    public int? NrSequencia { get; set; }

    public DateOnly? DtInicial { get; set; }

    public DateOnly? DtFim { get; set; }
}
