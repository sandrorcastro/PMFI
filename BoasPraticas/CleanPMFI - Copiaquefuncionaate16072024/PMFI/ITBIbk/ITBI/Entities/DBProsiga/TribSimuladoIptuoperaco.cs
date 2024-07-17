using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribSimuladoIptuoperaco
{
    public int OpeId { get; set; }

    public int? SimuId { get; set; }

    public string? Detalhes { get; set; }

    public virtual TribSimuladosIptu? Simu { get; set; }
}
