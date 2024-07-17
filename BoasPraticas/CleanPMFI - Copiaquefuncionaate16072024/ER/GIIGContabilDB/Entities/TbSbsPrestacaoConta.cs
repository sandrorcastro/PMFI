using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbSbsPrestacaoConta
{
    public int IdPrestacaoConta { get; set; }

    public int IdEmpresa { get; set; }

    public int IdSubvencaoSocial { get; set; }

    public int? IdPagamento { get; set; }

    public int? IdCatDespesa { get; set; }

    public int? IdTipoBeneficiario { get; set; }

    public int? IdPessoa { get; set; }

    public int? IdLiquidacao { get; set; }

    public int? IdEmpenho { get; set; }

    public int NrSeqMovimento { get; set; }

    public DateTime DtPrestacao { get; set; }

    public decimal? VlPrestadoContas { get; set; }

    public long? NrQuantidadeRealizada { get; set; }

    public int? IdReceita { get; set; }

    public string? DsJustificativa { get; set; }

    public int? IdTipoDoctoFiscal { get; set; }

    public string? NrDocFiscal { get; set; }

    public DateTime? DtDocFiscal { get; set; }

    public string? DsHistorico { get; set; }

    public int? IdTipoDoctoFinanceiro { get; set; }

    public long? NrDocumento { get; set; }

    public DateTime? DtDocumento { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtInclusao { get; set; }

    public short? MesCompetencia { get; set; }

    public short? NrParcela { get; set; }

    public string? DsPlacaVeiculo { get; set; }

    public int? NrQuilometragemVeiculo { get; set; }

    public string? CdModalidadeCompra { get; set; }

    public DateTime? DtDebito { get; set; }

    public string? CdtpDocumentoDespesa { get; set; }

    public int? CdTipoDespesa { get; set; }

    public short? NrBimestre { get; set; }

    public virtual TbSbsCategoriasDespesa? IdCatDespesaNavigation { get; set; }

    public virtual TbDspLiquidaco? IdLiquidacaoNavigation { get; set; }

    public virtual TbDspPagamento? IdPagamentoNavigation { get; set; }

    public virtual TbOrcReceita? IdReceitaNavigation { get; set; }

    public virtual TbSbsSubvencaoSocial IdSubvencaoSocialNavigation { get; set; } = null!;

    public virtual TbSbsTipoBeneficiario? IdTipoBeneficiarioNavigation { get; set; }

    public virtual TbDspTiposDocumentosFiscai? IdTipoDoctoFiscalNavigation { get; set; }
}
