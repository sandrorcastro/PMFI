using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspLiquidacaoConvenio
{
    public int IdLiqConvenio { get; set; }

    public int? IdLiquidacao { get; set; }

    public int? IdSubvencao { get; set; }

    public decimal? NrParcela { get; set; }
}
