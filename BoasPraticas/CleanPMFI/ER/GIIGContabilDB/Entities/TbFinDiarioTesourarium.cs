using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinDiarioTesourarium
{
    public int IdLancamentoDiario { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public int? IdLancamento { get; set; }

    public int? NrSequencia { get; set; }

    public DateTime? DtLancamento { get; set; }

    public string? TpOperacao { get; set; }

    public int? IdContaContabil { get; set; }

    public decimal? VlLancamento { get; set; }

    public string? NrDocumento { get; set; }

    public string? DsHistorico { get; set; }

    public int? IdCc { get; set; }

    public short? IdTipoOperacaoFinanceira { get; set; }

    public string? TpLancamento { get; set; }

    public bool? FlCaixa { get; set; }

    public virtual TbFinContasContabei? IdContaContabilNavigation { get; set; }

    public virtual TbFinContasContabeisLancamento? IdLancamentoNavigation { get; set; }

    public virtual TbFinTiposOperacoesFinanceira? IdTipoOperacaoFinanceiraNavigation { get; set; }

    public virtual ICollection<TbFinConciliacoesBancaria> TbFinConciliacoesBancaria { get; set; } = new List<TbFinConciliacoesBancaria>();

    public virtual ICollection<TbFinRegularizacaoDiarioTesourarium> TbFinRegularizacaoDiarioTesouraria { get; set; } = new List<TbFinRegularizacaoDiarioTesourarium>();
}
