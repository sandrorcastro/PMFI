﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribRevisaoDesconto
{
    public long ImoIddivida { get; set; }

    public int TipoTribId { get; set; }

    public decimal RevPercDesconto { get; set; }

    public string? RevObs { get; set; }
}
