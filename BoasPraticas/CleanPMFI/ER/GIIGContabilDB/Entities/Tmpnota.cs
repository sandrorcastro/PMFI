﻿using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class Tmpnota
{
    public int IdLiquidacaoDocto { get; set; }

    public DateTime? DtLiquidacao { get; set; }

    public DateTime? DtRecebimento { get; set; }
}
