﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribFiscAutoLancamentosDividasOrigem
{
    public int AutLanOrigId { get; set; }

    public int? AutoLanId { get; set; }

    public long? ImoIddivida { get; set; }

    public long? DivEmpId { get; set; }

    public long? ConIddivida { get; set; }
}
