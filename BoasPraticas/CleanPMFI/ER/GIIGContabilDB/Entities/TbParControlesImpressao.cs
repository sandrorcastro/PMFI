﻿using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbParControlesImpressao
{
    public int IdControleImpressao { get; set; }

    public string? NmObjeto { get; set; }

    public int? IdObjeto { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtImpressao { get; set; }
}
