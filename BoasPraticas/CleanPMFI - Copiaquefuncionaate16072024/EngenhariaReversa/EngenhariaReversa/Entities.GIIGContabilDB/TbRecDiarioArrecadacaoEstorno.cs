using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbRecDiarioArrecadacaoEstorno
    {
        public int IdEstorno { get; set; }
        public short? IdEmpresa { get; set; }
        public int? NrSequencia { get; set; }
        public short? NrAno { get; set; }
        public int? NrSequenciaOrigem { get; set; }
        public short? NrAnoOrigem { get; set; }
        public DateTime? DtEstorno { get; set; }
        public decimal? VlEstorno { get; set; }
        public string? DsEstorno { get; set; }
        public byte? NrMes { get; set; }
    }
}
