using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribFatorCorArea
{
    public int FatCorAreaId { get; set; }

    public decimal? FatCorAreaDe { get; set; }

    public decimal? FatCorAreaAte { get; set; }

    public decimal? FatCorAreaFator { get; set; }
}
