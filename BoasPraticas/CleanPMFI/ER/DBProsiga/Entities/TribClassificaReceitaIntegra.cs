﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribClassificaReceitaIntegra
{
    public DateTime DtClassifica { get; set; }

    public int IdConvenio { get; set; }

    public string IdBanco { get; set; } = null!;

    public string? FlSituacao { get; set; }
}
