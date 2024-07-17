using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class Tbsimdeducaolancamentocredito
{
    public int Idlancamento { get; set; }

    public int? Nrsequencia { get; set; }

    public int Nranosequencia { get; set; }

    public int Nrsequenciacredito { get; set; }

    public int Nranosequenciacredito { get; set; }

    public int Tipooperacao { get; set; }

    public int Idleiato { get; set; }

    public DateTime Dtdeducao { get; set; }

    public decimal Vldeducao { get; set; }
}
