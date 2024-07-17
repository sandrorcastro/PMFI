using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbsimdeducaodividaativaAux
{
    public int Idlancamento { get; set; }

    public int? NrsequenciaDa { get; set; }

    public int? NranosequenciaDa { get; set; }

    public int? Tipooperacao { get; set; }

    public int? Idleiato { get; set; }

    public DateTime? Dtdeducao { get; set; }

    public decimal? Vldeducao { get; set; }

    public string? Dsmotivo { get; set; }
}
