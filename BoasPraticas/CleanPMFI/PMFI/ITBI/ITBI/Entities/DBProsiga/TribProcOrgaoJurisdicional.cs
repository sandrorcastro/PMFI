﻿using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribProcOrgaoJurisdicional
{
    public int ProcOrgJurisId { get; set; }

    public string ProOrgJurisNome { get; set; } = null!;

    public virtual ICollection<TribProcProcesso> TribProcProcessos { get; set; } = new List<TribProcProcesso>();
}
