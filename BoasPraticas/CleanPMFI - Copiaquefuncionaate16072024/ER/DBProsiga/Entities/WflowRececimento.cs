﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class WflowRececimento
{
    public long RecId { get; set; }

    public DateTime? RecData { get; set; }

    public string? UsuId { get; set; }

    public virtual ICollection<WflowRemessa> Rems { get; set; } = new List<WflowRemessa>();
}
