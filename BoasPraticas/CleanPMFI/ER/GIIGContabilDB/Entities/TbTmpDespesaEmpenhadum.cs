﻿using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbTmpDespesaEmpenhadum
{
    public int IdDespesaEmpenhada { get; set; }

    public int? NrEmpenho { get; set; }

    public short? Ano { get; set; }

    public short? Mes { get; set; }

    public decimal? ValorEmpenhado { get; set; }

    public decimal? ValorEstornado { get; set; }

    public decimal? ValorLiquido { get; set; }

    public decimal? ValorRevertido { get; set; }
}
