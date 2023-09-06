using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpDespesaFornecedore
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public string? TpDespesa { get; set; }
        public short? IdEmpresaDesp { get; set; }
        public string? NmRazaoSocial { get; set; }
        public int? IdPessoa { get; set; }
        public string? NmPessoa { get; set; }
        public string? NmFantasia { get; set; }
        public string? NrCnpjcpf { get; set; }
        public short? NrAnoDespesa { get; set; }
        public short? NrDespesa { get; set; }
        public DateTime? DtDespesa { get; set; }
        public string? DsHistorico { get; set; }
        public string? NmTipoDoctoFiscal { get; set; }
        public string? NrDocumento { get; set; }
        public DateTime? DtDocumento { get; set; }
        public DateTime? DtVencimento { get; set; }
        public string? DsSerie { get; set; }
        public decimal? VlDespesa { get; set; }
        public decimal? VlDocumento { get; set; }
        public decimal? EstornoLiquidacaoDocumento { get; set; }
        public decimal? VlConsignadoDocto { get; set; }
        public decimal? VlPagamentoDocto { get; set; }
        public decimal? VlEstornoDespesa { get; set; }
        public decimal? VlPagamento { get; set; }
        public decimal? VlEstornoPagamento { get; set; }
        public decimal? EstConsg { get; set; }
        public string? CdDebito { get; set; }
        public string? DsDebito { get; set; }
        public string? CdCredito { get; set; }
        public string? DsCredito { get; set; }
        public string? CdFonte { get; set; }
        public short? NrDespesaOrigem { get; set; }
        public short? NrAnoDespesaOrigem { get; set; }
        public DateTime? DtDespesaOrigem { get; set; }
        public string? DsTipoContrato { get; set; }
        public int? NrContrato { get; set; }
        public short? NrAnoContrato { get; set; }
        public string? DsModalidade { get; set; }
        public short? NrAnolicitacao { get; set; }
        public int? NrLicitacao { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public string? NmUnidade { get; set; }
        public string? NmOrgao { get; set; }
        public DateTime? DtPagamento { get; set; }
    }
}
