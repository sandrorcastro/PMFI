using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpPublicidadeEmpenho
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public int? IdEmpenho { get; set; }
        public short? IdEmpresaEmp { get; set; }
        public string? NrCnpj { get; set; }
        public string? NmRazaoSocial { get; set; }
        public short? NrEmpenho { get; set; }
        public short? AnoEmpenho { get; set; }
        public DateTime? DtEmpenho { get; set; }
        public decimal? VlEmpenho { get; set; }
        public int? IdLiquidacao { get; set; }
        public short? NrAno { get; set; }
        public int? NrSequencia { get; set; }
        public DateTime? DtLiquidacao { get; set; }
        public decimal? VlLiquidacao { get; set; }
        public string? DsHistorico { get; set; }
        public string? CdOrgao { get; set; }
        public string? NmOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public string? NmUnidade { get; set; }
        public int? IdPessoa { get; set; }
        public string? NmPessoa { get; set; }
        public string? NrCnpjcpf { get; set; }
        public int? Iddotacao { get; set; }
        public int? IdNatDespesa { get; set; }
        public decimal? VlPago { get; set; }
        public string? Rms { get; set; }
        public decimal? VlrAnulado { get; set; }
        public decimal? VlrLiquidação { get; set; }
        public decimal? VlrCancelado { get; set; }
        public decimal? VlReversao { get; set; }
        public decimal? VlrConsignado { get; set; }
        public decimal? VlrPagamento { get; set; }
        public decimal? VlrDevolvido { get; set; }
        public decimal? VlrEstornoConsig { get; set; }
        public decimal? DescontoLiq { get; set; }
        public decimal? EstLiq { get; set; }
        public decimal? ConsigLiq { get; set; }
        public decimal? PagoLiq { get; set; }
        public decimal? EstPagLiq { get; set; }
        public decimal? EstExt { get; set; }
    }
}
