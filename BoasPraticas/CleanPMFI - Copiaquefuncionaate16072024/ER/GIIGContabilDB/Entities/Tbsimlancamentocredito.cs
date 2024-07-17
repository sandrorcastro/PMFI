using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class Tbsimlancamentocredito
{
    public int Idlancamento { get; set; }

    public int? Nranosequencia { get; set; }

    public int? Nrsequencia { get; set; }

    public int Idnaturezacredito { get; set; }

    public int Idtipocredito { get; set; }

    public int Idtipooperacao { get; set; }

    public DateTime Dtlancamento { get; set; }

    public int Nrmescompetencia { get; set; }

    public int Nranocompetencia { get; set; }

    public int Idleiato { get; set; }

    public decimal Vllancamento { get; set; }

    public decimal? Vlexcesso { get; set; }
}
