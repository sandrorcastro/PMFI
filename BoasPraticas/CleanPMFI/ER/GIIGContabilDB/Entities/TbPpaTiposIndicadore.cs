﻿using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPpaTiposIndicadore
{
    public int IdTipoIndicador { get; set; }

    public int? CdTipoIndicador { get; set; }

    public string? DsTipoIndicador { get; set; }

    public string? DsSiglaTipo { get; set; }
}
