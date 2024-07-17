using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribEmpresasFatorAreaConstruidum
{
    public short FatConstId { get; set; }

    public int? TipoTribId { get; set; }

    public decimal? FatConstAreaDe { get; set; }

    public decimal? FatConstAreaAte { get; set; }

    public decimal? FatConstFator { get; set; }

    public decimal FatConstQtdeMinUffi { get; set; }
}
