﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribProcArrestoPenhoraExecutado
{
    public long ProcArrId { get; set; }

    public long ConId { get; set; }

    public DateTime? ProcArrContribData { get; set; }

    public virtual TribProcArrestoPenhora ProcArr { get; set; } = null!;
}
