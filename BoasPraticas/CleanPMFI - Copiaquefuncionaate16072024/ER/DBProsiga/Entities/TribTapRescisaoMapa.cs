using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribTapRescisaoMapa
{
    public int IdMapaRescisao { get; set; }

    public int? ResId { get; set; }

    public long? TapMapaId { get; set; }

    public long? ImoIddivida { get; set; }

    public long? ConIddivida { get; set; }

    public long? EmpIddivida { get; set; }

    public int? TipoTribId { get; set; }

    public string? FlPago { get; set; }

    public string? FlParcial { get; set; }

    public DateTime? DtBaixa { get; set; }

    public decimal? VlPrincipal { get; set; }

    public decimal? VlPrincipalPago { get; set; }

    public decimal? VlTotalDivida { get; set; }

    public decimal? VlCompensado { get; set; }

    public virtual TribTapRescisao? Res { get; set; }

    public virtual TribTapMapa? TapMapa { get; set; }
}
