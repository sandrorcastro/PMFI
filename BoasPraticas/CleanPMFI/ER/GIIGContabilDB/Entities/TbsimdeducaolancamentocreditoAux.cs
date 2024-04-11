using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbsimdeducaolancamentocreditoAux
{
    public int Idlancamento { get; set; }

    public int Nrsequenciainscricao { get; set; }

    public int Nranosequenciainscricao { get; set; }

    public int Tipooperacao { get; set; }

    public DateTime Dtdeducao { get; set; }

    public decimal Vldeducao { get; set; }

    public string Dsmotivo { get; set; } = null!;

    public int? Idcredito { get; set; }
}
