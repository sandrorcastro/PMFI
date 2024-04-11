using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspPagamento
{
    public int IdPagamento { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public int? NrSequencia { get; set; }

    public int? NrSequenciaAnual { get; set; }

    public int? IdLiquidacao { get; set; }

    public int? IdDespesa { get; set; }

    public DateTime? DtPagamento { get; set; }

    public decimal? VlPagamento { get; set; }

    public decimal? VlRetencoes { get; set; }

    public short? IdTipoDocFinanceiro { get; set; }

    public string? NrDocumento { get; set; }

    public DateTime? DtDoctoPagamento { get; set; }

    public string? DsHistorico { get; set; }

    public int? IdCcfavorecido { get; set; }

    public int? IdCcempresa { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtInclusao { get; set; }

    public int? IdOrdemPagamento { get; set; }

    public int? IdCcarrecadadora { get; set; }

    public int? IdConsignacao { get; set; }

    public int? IdPessoaPagamento { get; set; }

    public virtual TbDspConsignaco? IdConsignacaoNavigation { get; set; }

    public virtual TbDspDespesaExtraOrcamentarium? IdDespesaNavigation { get; set; }

    public virtual TbDspLiquidaco? IdLiquidacaoNavigation { get; set; }

    public virtual TbDspOrdensPagamento? IdOrdemPagamentoNavigation { get; set; }

    public virtual TbFinTiposDocumentoFinanceiro? IdTipoDocFinanceiroNavigation { get; set; }

    public virtual ICollection<TbDspEstornosPagamento> TbDspEstornosPagamentos { get; set; } = new List<TbDspEstornosPagamento>();

    public virtual ICollection<TbDspPagamentosAporte> TbDspPagamentosAportes { get; set; } = new List<TbDspPagamentosAporte>();

    public virtual ICollection<TbSbsPrestacaoConta> TbSbsPrestacaoConta { get; set; } = new List<TbSbsPrestacaoConta>();
}
