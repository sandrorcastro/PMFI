﻿using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribTerrenoFace
{
    public int IdFace { get; set; }

    public long? TerrenoId { get; set; }

    public string? DsFace { get; set; }

    public string? DsValor { get; set; }
}
