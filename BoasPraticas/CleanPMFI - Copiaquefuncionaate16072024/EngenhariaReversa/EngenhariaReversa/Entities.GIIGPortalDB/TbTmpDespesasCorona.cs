using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpDespesasCorona
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public short? IdEmpresaEmp { get; set; }
        public string? NrCnpj { get; set; }
        public string? NmRazaoSocial { get; set; }
        public int? IdEmpenho { get; set; }
        public int? IdContrato { get; set; }
        public short? NrEmpenho { get; set; }
        public short? NrAno { get; set; }
        public DateTime? DtEmpenho { get; set; }
        public string? DsTipoEmpenho { get; set; }
        public string? DsHistorico { get; set; }
        public string? CdNatDespesa { get; set; }
        public string? DsNatDespesa { get; set; }
        public string? NrCnpjcpf { get; set; }
        public string? NmPessoa { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public string? CdFuncao { get; set; }
        public string? CdSubFuncao { get; set; }
        public string? CdPrograma { get; set; }
        public string? CdAcao { get; set; }
        public string? DsAcao { get; set; }
        public string? CdFonte { get; set; }
        public string? DsFonte { get; set; }
        public string? Unidade { get; set; }
        public string? Orgao { get; set; }
        public string? DsFuncao { get; set; }
        public string? DsSubFuncao { get; set; }
        public decimal? VlEmpenho { get; set; }
        public short? IdModalidade { get; set; }
        public string? DsModalidade { get; set; }
        public int? NrLicitacao { get; set; }
        public short? NrAnoLicitacao { get; set; }
        public string? NrEditalOrigem { get; set; }
        public decimal? VlrAnulado { get; set; }
        public decimal? VlrLiquidação { get; set; }
        public decimal? VlrCancelado { get; set; }
        public decimal? VlrConsignado { get; set; }
        public decimal? VlrPagamento { get; set; }
        public decimal? VlrDevolvido { get; set; }
        public decimal? VlrEstornoConsig { get; set; }
        public decimal? VlrSaldoPagar { get; set; }
    }
}
