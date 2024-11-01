﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribParede
{
    public int ParedeId { get; set; }

    public string? ParedeNome { get; set; }

    public decimal? ParedeFator { get; set; }

    public int? ParedePontos { get; set; }

    public virtual ICollection<TribEdificaco> TribEdificacos { get; set; } = new List<TribEdificaco>();
}
