using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribSimuladosIptuedifCarac
{
    public int SimuId { get; set; }

    public long EdificacaoId { get; set; }

    public int TparamId { get; set; }

    public int ParamId { get; set; }

    public int? Valor { get; set; }

    public virtual TribSimuladosIptuimovei TribSimuladosIptuimovei { get; set; } = null!;
}
