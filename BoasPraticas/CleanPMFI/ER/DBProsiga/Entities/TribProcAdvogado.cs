﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribProcAdvogado
{
    public long ProcId { get; set; }

    public long IdcontribCategProf { get; set; }

    public DateTime? DataInclusao { get; set; }

    public DateTime? DataExclusao { get; set; }

    public virtual TribProcProcesso Proc { get; set; } = null!;
}
