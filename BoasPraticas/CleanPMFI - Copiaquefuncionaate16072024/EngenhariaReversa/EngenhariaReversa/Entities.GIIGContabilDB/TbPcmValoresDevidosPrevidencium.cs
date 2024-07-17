using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPcmValoresDevidosPrevidencium
    {
        public int IdRegime { get; set; }
        public string? TpRegime { get; set; }
        public short? NrMesCompetencia { get; set; }
        public short? NrAnoCompetencia { get; set; }
        public decimal? VlBaseCalculo { get; set; }
        public decimal? VlDesconto { get; set; }
        public decimal? VlDevidoEmpregador { get; set; }
    }
}
