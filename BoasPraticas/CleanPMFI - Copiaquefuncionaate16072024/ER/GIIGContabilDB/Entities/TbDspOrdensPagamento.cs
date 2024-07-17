using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspOrdensPagamento
{
    public int IdOrdemPagamento { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public int? NrSequencia { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public int? IdRecurso { get; set; }

    public DateTime? DtOrdemPagamento { get; set; }

    public int? IdPessoa { get; set; }

    public int? IdCcempresa { get; set; }

    public int? IdCcfavorecido { get; set; }

    public int? IdCcarrecadadora { get; set; }

    public short? IdTipoDocFinanceiro { get; set; }

    public string? NrDocumento { get; set; }

    public DateTime? DtDoctoFinanceiro { get; set; }

    public DateTime? DtDoctoPagamento { get; set; }

    public decimal? VlOrdemPagamento { get; set; }

    public string? DsHistorico { get; set; }

    public string? DsSituacao { get; set; }

    public string? DsTipoOp { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtInclusao { get; set; }

    public DateTime? DtPagamento { get; set; }

    public DateTime? DtBaixa { get; set; }

    public int? IdAutorizacao { get; set; }

    public decimal? VlRetencoes { get; set; }

    public string? NrCodigoBarrasDj { get; set; }

    public int? IdAgencia { get; set; }

    public string? IdDepositoJudicial { get; set; }

    public virtual TbGerContasCorrente? IdCcempresaNavigation { get; set; }

    public virtual TbGerPessoa? IdPessoaNavigation { get; set; }

    public virtual TbFinTiposDocumentoFinanceiro? IdTipoDocFinanceiroNavigation { get; set; }

    public virtual ICollection<TbDspOrdensPagamentoDespesasExtra> TbDspOrdensPagamentoDespesasExtras { get; set; } = new List<TbDspOrdensPagamentoDespesasExtra>();

    public virtual ICollection<TbDspOrdensPagamentoDocumento> TbDspOrdensPagamentoDocumentos { get; set; } = new List<TbDspOrdensPagamentoDocumento>();

    public virtual ICollection<TbDspPagamento> TbDspPagamentos { get; set; } = new List<TbDspPagamento>();

    public virtual ICollection<TbFinOrdensCreditosDetalhe> TbFinOrdensCreditosDetalhes { get; set; } = new List<TbFinOrdensCreditosDetalhe>();
}
