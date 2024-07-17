using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribEditalInscrico
{
    public int EdiId { get; set; }

    public int LanImpImoAno { get; set; }

    public string InscricaoImobiliaria { get; set; } = null!;
}
