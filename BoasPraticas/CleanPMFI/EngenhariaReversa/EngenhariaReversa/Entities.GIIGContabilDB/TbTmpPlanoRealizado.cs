using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbTmpPlanoRealizado
    {
        public int? Spid { get; set; }
        public DateTime? DtExecucao { get; set; }
        public string? DsPlanoConta { get; set; }
        public int? IdConta { get; set; }
        public string? CdConta { get; set; }
        public string? DsConta { get; set; }
        public decimal? VlSaldoInicial { get; set; }
        public decimal? VlCreditosPeriodo { get; set; }
        public decimal? VlDebitosPeriodo { get; set; }
        public decimal? VlCreditosPeriodoSemEstorno { get; set; }
        public decimal? VlDebitosPeriodoSemEstorno { get; set; }
        public decimal? VlRealizado { get; set; }
        public string? DsTipoConta { get; set; }
        public int? IdContaSuperior { get; set; }
    }
}
