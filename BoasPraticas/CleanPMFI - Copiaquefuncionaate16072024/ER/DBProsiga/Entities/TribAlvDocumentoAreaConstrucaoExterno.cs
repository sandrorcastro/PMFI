using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribAlvDocumentoAreaConstrucaoExterno
{
    public int IdDocumentoAreaConstrucao { get; set; }

    public int IdDocumento { get; set; }

    public string DsTipoConstrucao { get; set; } = null!;

    public decimal? NrAreaConstrucao { get; set; }

    public string? DsTipoMaterial { get; set; }

    public string? DsTipoArea { get; set; }
}
