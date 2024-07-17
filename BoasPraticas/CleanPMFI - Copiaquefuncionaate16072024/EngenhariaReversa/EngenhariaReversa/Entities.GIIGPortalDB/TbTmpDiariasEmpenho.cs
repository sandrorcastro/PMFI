using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpDiariasEmpenho
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public short? IdEmpresaEmp { get; set; }
        public string? NmRazaoSocial { get; set; }
        public string? CdNatDespesa { get; set; }
        public string? TipoDespesa { get; set; }
        public string? DsNatDespesa { get; set; }
        public int? IdEmpenho { get; set; }
        public string? NmPessoa { get; set; }
        public string? NrCnpjcpf { get; set; }
        public short? NrAno { get; set; }
        public short? NrEmpenho { get; set; }
        public DateTime? DtEmpenho { get; set; }
        public decimal? NrQtde { get; set; }
        public decimal? VlUnitario { get; set; }
        public decimal? VlTotal { get; set; }
        public decimal? VlEmpenho { get; set; }
        public decimal? VlLiquidacao { get; set; }
        public decimal? VlPagamento { get; set; }
        public string? DsHistorico { get; set; }
        public DateTime? DtLiquidacao { get; set; }
        public DateTime? DtPagamento { get; set; }
        public string? Matricula { get; set; }
        public int? SeqLiq { get; set; }
        public int? SeqPag { get; set; }
        public string? OrgaoEmpenho { get; set; }
    }
}
