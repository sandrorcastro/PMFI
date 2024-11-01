﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribProcMotivo
{
    public int ProcMotId { get; set; }

    public string? ProcMotNome { get; set; }

    public virtual ICollection<TribProcSuspensaoMotivo> TribProcSuspensaoMotivos { get; set; } = new List<TribProcSuspensaoMotivo>();
}
