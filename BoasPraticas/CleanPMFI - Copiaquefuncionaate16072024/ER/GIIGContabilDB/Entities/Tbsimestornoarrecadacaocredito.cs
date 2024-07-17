using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class Tbsimestornoarrecadacaocredito
{
    public int Idlancamento { get; set; }

    public int? Nrsequencia { get; set; }

    public int? Nranosequencia { get; set; }

    public int? Nrsequenciacredito { get; set; }

    public int? Nranosequenciacredito { get; set; }

    public int? Nrmesestorno { get; set; }

    public int? Nranoestorno { get; set; }

    public decimal? Vlestorno { get; set; }

    public int? Idcredito { get; set; }
}
