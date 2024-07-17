using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinDividaFundadaMovimento
{
    public int IdMovimento { get; set; }

    public long IdDividaFundada { get; set; }

    public int? IdEmpresa { get; set; }

    public string? TpMovimento { get; set; }

    public string? TpOperacao { get; set; }

    public int? NrMovimento { get; set; }

    public short? NrAnoMovimento { get; set; }

    public int? IdContaContabil { get; set; }

    public DateTime? DtMovimento { get; set; }

    public string? NmOrigem { get; set; }

    public int? IdObjetoOrigem { get; set; }

    public short? NrParcelas { get; set; }

    public decimal? VlMovimento { get; set; }

    public string? DsOrigem { get; set; }

    public string? DsMotivo { get; set; }

    public int? IdMovimentoOrigem { get; set; }

    public int? IdLancamento { get; set; }
}
