using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbsimestornoarrecadacaocreditoAux
{
    public int Idlancamento { get; set; }

    public int NrsequenciaDa { get; set; }

    public int NranosequenciaDa { get; set; }

    public int? Nrsequenciacredito { get; set; }

    public int? Nranosequenciacredito { get; set; }

    public int Nrmesestorno { get; set; }

    public int Nranoestorno { get; set; }

    public decimal Vlestorno { get; set; }

    public int Idcredito { get; set; }
}
