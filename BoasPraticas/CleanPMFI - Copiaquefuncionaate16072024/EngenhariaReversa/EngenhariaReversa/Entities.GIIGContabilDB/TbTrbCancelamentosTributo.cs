using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbTrbCancelamentosTributo
    {
        public int IdCancelamento { get; set; }
        public short? NrExercicio { get; set; }
        public byte? NrBimestre { get; set; }
        public short? NrExercicioDivida { get; set; }
        public int? NrContribuintes { get; set; }
        public string? NmContribuinte { get; set; }
        public decimal? VlCancelado { get; set; }
        public string? DsMotivo { get; set; }
        public short? IdTipoCancelamento { get; set; }
    }
}
