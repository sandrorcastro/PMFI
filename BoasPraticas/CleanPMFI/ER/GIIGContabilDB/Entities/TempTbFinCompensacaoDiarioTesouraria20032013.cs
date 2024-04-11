﻿using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TempTbFinCompensacaoDiarioTesouraria20032013
{
    public int IdCompensacaoDiario { get; set; }

    public int? IdLancamentoDiario { get; set; }

    public short? NrSequencial { get; set; }

    public int? IdExtrato { get; set; }

    public int? IdConciliacao { get; set; }

    public DateTime? DtCompensacao { get; set; }

    public decimal? VlCompensacao { get; set; }

    public int? IdEstorno { get; set; }

    public string? FlTipo { get; set; }
}
