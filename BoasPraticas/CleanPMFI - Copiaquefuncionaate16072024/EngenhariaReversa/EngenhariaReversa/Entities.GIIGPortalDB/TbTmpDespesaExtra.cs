using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpDespesaExtra
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public string? NrCnpj { get; set; }
        public string? NmRazaoSocial { get; set; }
        public int? IdDespesa { get; set; }
        public short? NrAno { get; set; }
        public short? NrSequencia { get; set; }
        public DateTime? DtDespesa { get; set; }
        public string? NrCnpjcpf { get; set; }
        public int? IdPessoa { get; set; }
        public string? NmPessoa { get; set; }
        public string? NmFantasia { get; set; }
        public string? DsHistorico { get; set; }
        public decimal? VlDespesa { get; set; }
        public decimal? TotalEstorno { get; set; }
        public decimal? TotalPago { get; set; }
        public decimal? VlTotalEstornoPagamento { get; set; }
        public string? DsGrupo { get; set; }
        public string? CdGrupo { get; set; }
    }
}
