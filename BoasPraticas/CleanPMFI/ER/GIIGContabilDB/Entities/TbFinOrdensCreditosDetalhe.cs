using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinOrdensCreditosDetalhe
{
    public int IdDetalhe { get; set; }

    public int IdOrdemCredito { get; set; }

    public int? IdOrdemPagamento { get; set; }

    public int? IdLiquidacaoDocto { get; set; }

    public int? IdConsignacao { get; set; }

    public string? CdTipoServico { get; set; }

    public string? CdFormaLancamento { get; set; }

    public int? NrSequencia { get; set; }

    public int? IdCcdestino { get; set; }

    public decimal? VlRetencoes { get; set; }

    public decimal? VlDetalhe { get; set; }

    public string? DsOcorrencia { get; set; }

    public string? DsSituacao { get; set; }

    public string? Dsjustificativa { get; set; }

    public int? NrSeqExclusao { get; set; }

    public DateTime? DtExclusao { get; set; }

    public string? DsloginExclusao { get; set; }

    public string? IdTipoIndicadorPagamento { get; set; }

    public string? NrIndicadorPagamento { get; set; }

    public string? CdOcorrencia { get; set; }

    public int? NrOrdemBancaria { get; set; }

    public virtual TbGerContasCorrente? IdCcdestinoNavigation { get; set; }

    public virtual TbFinOrdensCredito IdOrdemCreditoNavigation { get; set; } = null!;

    public virtual TbDspOrdensPagamento? IdOrdemPagamentoNavigation { get; set; }
}
