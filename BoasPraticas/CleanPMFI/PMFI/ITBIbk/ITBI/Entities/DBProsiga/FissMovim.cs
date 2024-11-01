﻿using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class FissMovim
{
    public long MovId { get; set; }

    public DateTime? MovData { get; set; }

    public string? MovMotivo { get; set; }

    public int? TipoOpId { get; set; }

    public virtual ICollection<FissDocFiscai> FissDocFiscais { get; set; } = new List<FissDocFiscai>();

    public virtual ICollection<FissMovimImg> FissMovimImgs { get; set; } = new List<FissMovimImg>();

    public virtual FissTipoOperacao? TipoOp { get; set; }
}
