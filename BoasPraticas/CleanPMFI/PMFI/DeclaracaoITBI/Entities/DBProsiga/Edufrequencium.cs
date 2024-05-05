using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class Edufrequencium
{
    public long FreqId { get; set; }

    public int? FreqAno { get; set; }

    public int? FreqMes { get; set; }

    public long TipoPdid { get; set; }

    public decimal? FreqValor { get; set; }

    public long DadFid { get; set; }

    public virtual RhdadosFuncionai DadF { get; set; } = null!;

    public virtual RhtipoProventosDesconto TipoPd { get; set; } = null!;
}
