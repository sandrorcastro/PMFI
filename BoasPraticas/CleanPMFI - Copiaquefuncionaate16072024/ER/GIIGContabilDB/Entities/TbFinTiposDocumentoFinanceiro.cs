using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinTiposDocumentoFinanceiro
{
    public short IdTipoDocFinanceiro { get; set; }

    public string? NmTipoDocFinanceiro { get; set; }

    public short? CdTipoTc { get; set; }

    public bool? FlAtivo { get; set; }

    public string? FlEntradaSaida { get; set; }

    public virtual ICollection<TbDspOrdensPagamento> TbDspOrdensPagamentos { get; set; } = new List<TbDspOrdensPagamento>();

    public virtual ICollection<TbDspPagamento> TbDspPagamentos { get; set; } = new List<TbDspPagamento>();

    public virtual ICollection<TbFinConciliacoesBancaria> TbFinConciliacoesBancaria { get; set; } = new List<TbFinConciliacoesBancaria>();

    public virtual ICollection<TbFinContasContabeisLancamentosAnalisador> TbFinContasContabeisLancamentosAnalisadors { get; set; } = new List<TbFinContasContabeisLancamentosAnalisador>();

    public virtual ICollection<TbRecMovimentoReceita> TbRecMovimentoReceita { get; set; } = new List<TbRecMovimentoReceita>();

    public virtual ICollection<TbFinTiposOperacoesFinanceira> IdTipoOperacaoFinanceiras { get; set; } = new List<TbFinTiposOperacoesFinanceira>();
}
