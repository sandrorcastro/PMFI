﻿using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribRequerimentosRevisao
{
    public long ReqRevId { get; set; }

    public DateTime? ReqRevData { get; set; }

    public int? ReqRevAnoProtoc { get; set; }

    public int? ReqRevNumProtoc { get; set; }

    public string? ReqRevNome { get; set; }

    public virtual ICollection<TribRequerimentoRevisaoImovei> TribRequerimentoRevisaoImoveis { get; set; } = new List<TribRequerimentoRevisaoImovei>();
}
