using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpRazaoContabilOld1
    {
        public DateTime? DtExecucao { get; set; }
        public short? IdEmpresa { get; set; }
        public int? IdContaContabil { get; set; }
        public decimal? VlSaldoInicial { get; set; }
        public decimal? ValorSaida { get; set; }
        public decimal? ValorEntrada { get; set; }
        public string? CdContaContabil { get; set; }
        public string? DsContaContabil { get; set; }
        public DateTime? DtLancamento { get; set; }
        public string? DsHistorico { get; set; }
        public int? NrSequencial { get; set; }
        public int? IdLancamento { get; set; }
        public string? DsOrigem { get; set; }
        public short? Nrano { get; set; }
        public short? NrMes { get; set; }
        public decimal? VlSaldoInicialContaCont { get; set; }
    }
}
