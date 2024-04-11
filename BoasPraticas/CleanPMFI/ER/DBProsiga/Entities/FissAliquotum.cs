using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class FissAliquotum
{
    public long AliqId { get; set; }

    public string? AliqDescricao { get; set; }

    public decimal? AliqAliquota { get; set; }
}
