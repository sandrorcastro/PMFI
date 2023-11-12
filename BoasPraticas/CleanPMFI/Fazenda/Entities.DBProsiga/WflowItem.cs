﻿using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class WflowItem
{
    public int WflowItemId { get; set; }

    public string? WflowItemDescr { get; set; }

    public virtual ICollection<WflowRequisicaoIten> WflowRequisicaoItens { get; set; } = new List<WflowRequisicaoIten>();
}
