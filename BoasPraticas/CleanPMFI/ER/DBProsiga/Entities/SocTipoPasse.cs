﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SocTipoPasse
{
    public long TpassId { get; set; }

    public string? TpassNome { get; set; }

    public string? TpassDescricao { get; set; }

    public virtual ICollection<SocPasse> SocPasses { get; set; } = new List<SocPasse>();
}
