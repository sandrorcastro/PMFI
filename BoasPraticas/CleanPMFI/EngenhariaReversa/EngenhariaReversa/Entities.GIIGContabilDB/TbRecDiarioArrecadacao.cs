using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbRecDiarioArrecadacao
    {
        public int IdLctoDiario { get; set; }
        public short? NrBimestre { get; set; }
        public short? NrAno { get; set; }
        public int? IdEmpresa { get; set; }
        public int? NrOrdem { get; set; }
        public DateTime? DtLancamento { get; set; }
        public DateTime? DtLancamentoContabil { get; set; }
        public string? TpOperacao { get; set; }
        public string? CdReceita { get; set; }
        public decimal? VlLancamento { get; set; }
        public string? NmContribuinte { get; set; }
        public string? TpDocumento { get; set; }
        public string? NrDocumento { get; set; }
        public string? DsHistorico { get; set; }
        public string? FlExcluido { get; set; }
        public DateTime? DtExclusao { get; set; }
        public string? DsLogin { get; set; }
        public short? IdTipoArrecadacao { get; set; }
        public short? IdTipoOrigemReceita { get; set; }
        public int? IdCredito { get; set; }
        public short? NrMes { get; set; }
        public int? IdLctoDiarioOrigem { get; set; }
        public short? IdTipoOperacaoReceita { get; set; }
    }
}
