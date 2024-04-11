using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribFiscAutoInfracoesDividasOrigem
{
    public int AutOrigId { get; set; }

    public int? AutoId { get; set; }

    public long? ImoIddivida { get; set; }

    public long? DivEmpId { get; set; }

    public long? ConIddivida { get; set; }
}
