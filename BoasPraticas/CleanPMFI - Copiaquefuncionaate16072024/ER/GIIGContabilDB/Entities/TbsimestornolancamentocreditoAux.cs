using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbsimestornolancamentocreditoAux
{
    public int Idlancamento { get; set; }

    public int Nrsequenciainscricao { get; set; }

    public int Nranosequenciainscricao { get; set; }

    public DateTime Dtestorno { get; set; }

    public decimal Vlestorno { get; set; }

    public string Dsmotivo { get; set; } = null!;
}
