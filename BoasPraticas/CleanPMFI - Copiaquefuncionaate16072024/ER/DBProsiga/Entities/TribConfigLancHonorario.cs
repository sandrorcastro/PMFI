using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribConfigLancHonorario
{
    public int LancHonId { get; set; }

    public int TipoBxId { get; set; }

    public string ConsiderarValorAtual { get; set; } = null!;

    public virtual TribTipoBaixa TipoBx { get; set; } = null!;
}
