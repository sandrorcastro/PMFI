﻿using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCtcRateio
{
    public int IdRateio { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtInclusao { get; set; }

    public DateTime? DtInicio { get; set; }

    public DateTime? DtFim { get; set; }
}
