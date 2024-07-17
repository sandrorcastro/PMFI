using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaRotinaIntegracao
{
    public int IdLogRotina { get; set; }

    public string? DsRotina { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtGeracao { get; set; }

    public string? DsResult { get; set; }
}
