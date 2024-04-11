using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcArtigosCreditoAdicional
{
    public int IdArtigo { get; set; }

    public int? IdEmpresa { get; set; }

    public int? IdLeiAto { get; set; }

    public int? NrLei { get; set; }

    public short? NrAnoLei { get; set; }

    public string? NrArtigo { get; set; }

    public string? DsArtigo { get; set; }

    public string? TpArtigo { get; set; }

    public short? IdEmpresaExecutor { get; set; }

    public decimal? VlPercentual { get; set; }

    public virtual ICollection<TbOrcAutorizacaoCreditoAdicional> TbOrcAutorizacaoCreditoAdicionals { get; set; } = new List<TbOrcAutorizacaoCreditoAdicional>();

    public virtual ICollection<TbOrcLimitesCreditoAdicional> TbOrcLimitesCreditoAdicionals { get; set; } = new List<TbOrcLimitesCreditoAdicional>();
}
