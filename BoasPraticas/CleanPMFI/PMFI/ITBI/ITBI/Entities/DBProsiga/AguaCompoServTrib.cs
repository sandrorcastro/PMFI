﻿using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class AguaCompoServTrib
{
    public int CompoServId { get; set; }

    public int? TipoServId { get; set; }

    public int? TipoTribId { get; set; }

    public string? CompoServTaxaPrinc { get; set; }
}
