using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class VwSaldosMensaisContasContabeisTipoSuperavit
    {
        public int IdSaldo { get; set; }
        public short? NrMes { get; set; }
        public int? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public string? CdContaContabil { get; set; }
        public decimal? VlSaldoInicial { get; set; }
        public decimal? VlCredito { get; set; }
        public decimal? VlCreditoSemEstorno { get; set; }
        public decimal? VlDebito { get; set; }
        public decimal? VlDebitoSemEstorno { get; set; }
        public decimal? VlSaldoProximo { get; set; }
        public decimal? VlDebitoCredito { get; set; }
        public decimal? VlCreditoDebito { get; set; }
        public string? TpIndicSupFinanc { get; set; }
        public string? DsTipoContaPadrao { get; set; }
    }
}
