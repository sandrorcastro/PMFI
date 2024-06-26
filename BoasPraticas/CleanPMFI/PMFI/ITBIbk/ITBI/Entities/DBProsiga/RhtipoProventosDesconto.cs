﻿using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class RhtipoProventosDesconto
{
    public long TipoPdid { get; set; }

    public string? TipoPdnome { get; set; }

    public string? TipoPdprovDesc { get; set; }

    public string? TipoPdformaCalc { get; set; }

    public virtual ICollection<Edufrequencium> Edufrequencia { get; set; } = new List<Edufrequencium>();
}
