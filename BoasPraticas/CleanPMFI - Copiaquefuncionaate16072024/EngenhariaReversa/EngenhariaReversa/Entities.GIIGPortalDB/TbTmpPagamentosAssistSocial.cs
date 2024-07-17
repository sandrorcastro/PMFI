using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpPagamentosAssistSocial
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public string? NrCnpj { get; set; }
        public string? NmRazaoSocial { get; set; }
        public int? IdPagamento { get; set; }
        public string? TipoDespesa { get; set; }
        public string? DsHistorico { get; set; }
        public string? EmpHistorico { get; set; }
        public DateTime? DtPagamento { get; set; }
        public short? NrAno { get; set; }
        public string? NrDocumento { get; set; }
        public string? NmTipoDocFinanceiro { get; set; }
        public int? NrSequencia { get; set; }
        public decimal? VlPagamento { get; set; }
        public short? MesCompetencia { get; set; }
        public decimal? VlRetencoes { get; set; }
        public short? NrAnoDespesa { get; set; }
        public short? NrDespesa { get; set; }
        public int? IdPessoa { get; set; }
        public string? NmPessoa { get; set; }
        public string? NrCnpjcpf { get; set; }
        public int? Iddotacao { get; set; }
        public string? CdOrgao { get; set; }
        public string? NmOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public string? NmUnidade { get; set; }
        public int? NrSequenciaLiquidacao { get; set; }
        public short? NrAnoLiquidacao { get; set; }
        public DateTime? DtLiquidacao { get; set; }
        public DateTime? DtDespesa { get; set; }
        public int? SeqAnualLiquidacao { get; set; }
        public int? SqAnualPgto { get; set; }
        public string? CdContaContabil { get; set; }
        public string? DsContaContabil { get; set; }
        public int? IdNatDespesa { get; set; }
        public string? CdFonte { get; set; }
        public string? DsFonte { get; set; }
        public string? NmTipoDoctoFiscal { get; set; }
        public string? NrDocumentoFiscal { get; set; }
        public string? DsSerie { get; set; }
        public DateTime? DtDocumento { get; set; }
        public DateTime? DtVencimento { get; set; }
        public decimal? VlDocumento { get; set; }
        public decimal? VlPagamentoDocto { get; set; }
        public decimal? VlRetencoesDocto { get; set; }
        public int? IdRecurso { get; set; }
        public string? DsRecurso { get; set; }
        public decimal? VlEmpenho { get; set; }
        public decimal? VlAnulado { get; set; }
    }
}
