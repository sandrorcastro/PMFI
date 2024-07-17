using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TempTbCntAtosContratuaisItensLicitacao
    {
        public int IdAtoContratoItem { get; set; }
        public int IdAtoContratual { get; set; }
        public int IdItem { get; set; }
        public int NrLote { get; set; }
        public string? DsTipoOperacao { get; set; }
        public decimal? NrQtdAditivada { get; set; }
        public decimal? VlUnitAditivado { get; set; }
        public decimal? VlTotalAditivado { get; set; }
        public short? IdTipoRedimensionamento { get; set; }
    }
}
