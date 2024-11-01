﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class GccTipoOcor
{
    public string TocorCnpjmembro { get; set; } = null!;

    public int TocorId { get; set; }

    public string? TocorDescr { get; set; }

    public virtual ICollection<GccMovtoOcor> GccMovtoOcors { get; set; } = new List<GccMovtoOcor>();
}
